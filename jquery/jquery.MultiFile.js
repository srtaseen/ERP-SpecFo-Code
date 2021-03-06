
;if(window.jQuery) (function($){ 	
	$.fn.MultiFile = function(options){
		if(this.length==0) return this; 		
		if(typeof arguments[0]=='string'){		
			if(this.length>1){
				var args = arguments;
				return this.each(function(){
					$.fn.MultiFile.apply($(this), args);
    });
			};			
			$.fn.MultiFile[arguments[0]].apply(this, $.makeArray(arguments).slice(1) || []);		
			return this;
		};		
		
		var options = $.extend(
			{},
			$.fn.MultiFile.options,
			options || {}
		);		
		
		$('form')
		.not('MultiFile-intercepted')
		.addClass('MultiFile-intercepted')
		.submit($.fn.MultiFile.disableEmpty);
		
		
		if($.fn.MultiFile.options.autoIntercept){
			$.fn.MultiFile.intercept( $.fn.MultiFile.options.autoIntercept);
			$.fn.MultiFile.options.autoIntercept = null; /* only run this once */
		};
				
		this
		 .not('.MultiFile-applied')
			.addClass('MultiFile-applied')
		.each(function(){
		
       window.MultiFile = (window.MultiFile || 0) + 1;
       var group_count = window.MultiFile;     
       var MultiFile = {e:this, E:$(this), clone:$(this).clone()};          
       if(typeof options=='number') options = {max:options};
       var o = $.extend({},
        $.fn.MultiFile.options,
        options || {},
   		($.metadata? MultiFile.E.metadata(): ($.meta?MultiFile.E.data():null)) || {}, {}
       );
      
       if(!(o.max>0)){
        o.max = MultiFile.E.attr('maxlength');
        if(!(o.max>0)){
         o.max = (String(MultiFile.e.className.match(/\b(max|limit)\-([0-9]+)\b/gi) || ['']).match(/[0-9]+/gi) || [''])[0];
         if(!(o.max>0)) o.max = -1;
         else           o.max = String(o.max).match(/[0-9]+/gi)[0];
        }
       };
       o.max = new Number(o.max);    
       o.accept = o.accept || MultiFile.E.attr('accept') || '';
       if(!o.accept){
        o.accept = (MultiFile.e.className.match(/\b(accept\-[\w\|]+)\b/gi)) || '';
        o.accept = new String(o.accept).replace(/^(accept|ext)\-/i,'');
       };       
      
	    $.extend(MultiFile, o || {});
       MultiFile.STRING = $.extend({},$.fn.MultiFile.options.STRING,MultiFile.STRING);
       
     
    
       $.extend(MultiFile, {
        n: 0, 
        slaves: [], files: [],
        instanceKey: MultiFile.e.id || 'MultiFile'+String(group_count), 
        generateID: function(z){ return MultiFile.instanceKey + (z>0 ?'_F'+String(z):''); },
        trigger: function(event, element){
         var handler = MultiFile[event], value = $(element).attr('value');
         if(handler){
          var returnValue = handler(element, value, MultiFile);
          if( returnValue!=null ) return returnValue;
         }
         return true;
        }
       });      
      
     
       if(String(MultiFile.accept).length>1){
								MultiFile.accept = MultiFile.accept.replace(/\W+/g,'|').replace(/^\W|\W$/g,'');
        MultiFile.rxAccept = new RegExp('\\.('+(MultiFile.accept?MultiFile.accept:'')+')$','gi');
       };
       
     
   
       MultiFile.wrapID = MultiFile.instanceKey+'_wrap'; // Wrapper ID?
       MultiFile.E.wrap('<div class="MultiFile-wrap" id="'+MultiFile.wrapID+'"></div>');
       MultiFile.wrapper = $('#'+MultiFile.wrapID+'');
       
       //===
       
    
       MultiFile.e.name = MultiFile.e.name || 'file'+ group_count +'[]';
       
       //===
       
							if(!MultiFile.list){							
								MultiFile.wrapper.append( '<div class="MultiFile-list" id="'+MultiFile.wrapID+'_list"></div>' );
								MultiFile.list = $('#'+MultiFile.wrapID+'_list');
							};
       MultiFile.list = $(MultiFile.list);	
       MultiFile.addSlave = function( slave, slave_count ){						
								
     
        MultiFile.n++;      
        slave.MultiFile = MultiFile;							
								if(slave_count>0) slave.id = slave.name = '';							
     							if(slave_count>0) slave.id = MultiFile.generateID(slave_count);							
     slave.name = String(MultiFile.namePattern
     .replace(/\$name/gi,$(MultiFile.clone).attr('name'))
     .replace(/\$id/gi,  $(MultiFile.clone).attr('id'))
     .replace(/\$g/gi,   group_count)
     .replace(/\$i/gi,   slave_count)
        );
        
      
        if( (MultiFile.max > 0) && ((MultiFile.n-1) > (MultiFile.max)) )
         slave.disabled = true;               
        MultiFile.current = MultiFile.slaves[slave_count] = slave;								
								slave = $(slave);      
        slave.val('').attr('value','')[0].value = '';       
		slave.addClass('MultiFile-applied');								
      
        slave.change(function(){         
          $(this).blur();
          
         
          if(!MultiFile.trigger('onFileSelect', this, MultiFile)) return false;         
          var ERROR = '', v = String(this.value || '');       
          if(MultiFile.accept && v && !v.match(MultiFile.rxAccept))
            ERROR = MultiFile.STRING.denied.replace('$ext', String(v.match(/\.\w{1,4}$/gi)));
             
		   for(var f in MultiFile.slaves)
           if(MultiFile.slaves[f] && MultiFile.slaves[f]!=this)
           if(MultiFile.slaves[f].value==v)//{
           ERROR = MultiFile.STRING.duplicate.replace('$file', v.match(/[^\/\\]+$/gi));
         
          var newEle = $(MultiFile.clone).clone();        
          newEle.addClass('MultiFile');          
        
          if(ERROR!=''){      
            MultiFile.error(ERROR);		
            MultiFile.n--;
            MultiFile.addSlave(newEle[0], slave_count);
            slave.parent().prepend(newEle);
            slave.remove();
            return false;
          };         
       
          $(this).css({ position:'absolute', top: '-3000px' });        
          slave.after(newEle);        
          MultiFile.addToList( this, slave_count );               
          MultiFile.addSlave( newEle[0], slave_count+1 );                 
          if(!MultiFile.trigger('afterFileSelect', this, MultiFile)) return false;       

      });
        $(slave).data('MultiFile', MultiFile);								
       };       
     MultiFile.addToList = function( slave, slave_count ){
     if(!MultiFile.trigger('onFileAppend', slave, MultiFile)) return false;      
        var
         r = $('<div class="MultiFile-label"></div>'),
         v = String(slave.value || ''/*.attr('value)*/),
         a = $('<span class="MultiFile-title" title="'+MultiFile.STRING.selected.replace('$file', v)+'">'+MultiFile.STRING.file.replace('$file', v.match(/[^\/\\]+$/gi)[0])+'</span>'),
         b = $('<a class="MultiFile-remove" href="#'+MultiFile.wrapID+'">'+MultiFile.STRING.remove+'</a>');
         MultiFile.list.append(
         r.append(b, ' ', a)
        );        
        b
	.click(function(){        
                  if(!MultiFile.trigger('onFileRemove', slave, MultiFile)) return false;           
          MultiFile.n--;
          MultiFile.current.disabled = false;          
       
										MultiFile.slaves[slave_count] = null;
										$(slave).remove();
										$(this).parent().remove();										
         
          $(MultiFile.current).css({ position:'', top: '' });
										$(MultiFile.current).reset().val('').attr('value', '')[0].value = '';         
          if(!MultiFile.trigger('afterFileRemove', slave, MultiFile)) return false;      
	      return false;
        });       
       if(!MultiFile.trigger('afterFileAppend', slave, MultiFile)) return false;      
       };      
      
       if(!MultiFile.MultiFile) MultiFile.addSlave(MultiFile.e, 0);    
       MultiFile.n++;							
						
	MultiFile.E.data('MultiFile', MultiFile);						
    }); 
	};		
	$.extend($.fn.MultiFile, { 
  reset: function(){
			var settings = $(this).data('MultiFile');		
			if(settings) settings.list.find('a.MultiFile-remove').click();
   return $(this);
  }, 
   
  disableEmpty: function(klass){ klass = String(klass || 'mfD');
   var o = [];
   $('input:file').each(function(){ if($(this).val()=='') o[o.length] = this; });
   return $(o).each(function(){ this.disabled = true }).addClass(klass);
  }, 
   
  reEnableEmpty: function(klass){ klass = String(klass || 'mfD');
   return $('input:file.'+klass).removeClass(klass).each(function(){ this.disabled = false });
  },
   
  intercepted: {},
  intercept: function(methods, context, args){
   var method, value; args = args || [];
   if(args.constructor.toString().indexOf("Array")<0) args = [ args ];
   if(typeof(methods)=='function'){
    $.fn.MultiFile.disableEmpty();
    value = methods.apply(context || window, args);			
				setTimeout(function(){ $.fn.MultiFile.reEnableEmpty() },1000);
    return value;
   };
   if(methods.constructor.toString().indexOf("Array")<0) methods = [methods];
   for(var i=0;i<methods.length;i++){
    method = methods[i]+''; 
    if(method) (function(method){ 
     $.fn.MultiFile.intercepted[method] = $.fn[method] || function(){};
     $.fn[method] = function(){
      $.fn.MultiFile.disableEmpty();
      value = $.fn.MultiFile.intercepted[method].apply(this, arguments);				
      setTimeout(function(){ $.fn.MultiFile.reEnableEmpty() },1000);
      return value;
     };
    })(method); 
   };
  }
 });
	
	
	$.fn.MultiFile.options = { 
		accept: '', 
		max: -1,	
		namePattern: '$name',		
		STRING: {
			remove:'x',
			denied:'You cannot select a $ext file.\nTry again...',file:'$file',
			selected:'File selected: $file',
			duplicate:'This file has already been selected:\n$file'
		},
			
  autoIntercept: [ 'submit', 'ajaxSubmit', 'ajaxForm', 'validate' /* array of methods to intercept */ ],	
  error: function(s){		
			 alert(s);		
		}
 }; 	

	$.fn.reset = function(){ return this.each(function(){ try{ this.reset(); }catch(e){} }); };
    $(function(){
  $("input[type=file].multi").MultiFile();
 });
})(jQuery);
