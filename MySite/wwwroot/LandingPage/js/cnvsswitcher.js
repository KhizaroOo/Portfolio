SEMICOLON.Modules.bootstrap();const cnvsCustomizer=()=>{const cnvsSwitcher=new bootstrap.Offcanvas('#cnvs-style-switcher');const cnvsSwitcherEl=document.getElementById('cnvs-style-switcher');const cnvsSwitcherPreloaders=document.querySelectorAll('.cnvs-switcher-preloaders button');const cnvsSwitcherPrimaryFont=document.getElementById('cnvs-switcher-primary-font');const cnvsSwitcherBodyFont=document.getElementById('cnvs-switcher-body-font');const cnvsSwitcherColors=document.querySelectorAll('.cnvs-switcher-colors button');const cnvsSwitcherNicheDemos=document.getElementById('cnvs-switcher-niche-demos');const cnvsSwitcherOpHideNicheDemos=document.querySelectorAll('.cnvs-switcher-op-no-niche-demos');const cnvsHEXtoRGBA=hex=>{let c;if(/^#([A-Fa-f0-9]{3}){1,2}$/.test(hex)){c=hex.substring(1).split('');if(c.length==3){c=[c[0],c[0],c[1],c[1],c[2],c[2]];}
c='0x'+c.join('');return[(c>>16)&255,(c>>8)&255,c&255].join(',');}
console.log('Bad Hex');};const cnvsSwitcherFilePath=window.location.pathname;const cnvsSwitcherFileName=cnvsSwitcherFilePath.split('/').pop();if(cnvsSwitcherFileName.startsWith("demo-")){cnvsSwitcherOpHideNicheDemos.forEach(el=>{el.remove();});localStorage.removeItem('cnvsBodyColorScheme');SEMICOLON.Core.colorScheme();}else{SEMICOLON.Core.loadCSS({file:"css/preview-styles.css",id:"cnvs-preview-styles"});}
cnvsSwitcherColors.forEach(el=>{el.onclick=e=>{e.preventDefault();let elColor=el.getAttribute('data-color');document.documentElement.style.setProperty('--cnvs-themecolor',elColor);document.documentElement.style.setProperty('--cnvs-themecolor-rgb',cnvsHEXtoRGBA(elColor));};});cnvsSwitcherPreloaders.forEach(el=>{el.onclick=e=>{e.preventDefault();cnvsSwitcher.hide();let elLoader=el.getAttribute('data-loader'),elLoaderAppend,pageTransition=document.querySelector('.page-transition-wrap');if(elLoader=='2'){elLoaderAppend='<div class="css3-spinner-flipper"></div>';}else if(elLoader=='3'){elLoaderAppend='<div class="css3-spinner-double-bounce1"></div><div class="css3-spinner-double-bounce2"></div>';}else if(elLoader=='4'){elLoaderAppend='<div class="css3-spinner-rect1"></div><div class="css3-spinner-rect2"></div><div class="css3-spinner-rect3"></div><div class="css3-spinner-rect4"></div><div class="css3-spinner-rect5"></div>';}else if(elLoader=='5'){elLoaderAppend='<div class="css3-spinner-cube1"></div><div class="css3-spinner-cube2"></div>';}else if(elLoader=='6'){elLoaderAppend='<div class="css3-spinner-scaler"></div>';}else if(elLoader=='7'){elLoaderAppend='<div class="css3-spinner-grid-pulse"><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div></div>';}else if(elLoader=='8'){elLoaderAppend='<div class="css3-spinner-clip-rotate"><div></div></div>';}else if(elLoader=='9'){elLoaderAppend='<div class="css3-spinner-ball-rotate"><div></div><div></div><div></div></div>';}else if(elLoader=='10'){elLoaderAppend='<div class="css3-spinner-zig-zag"><div></div><div></div></div>';}else if(elLoader=='11'){elLoaderAppend='<div class="css3-spinner-triangle-path"><div></div><div></div><div></div></div>';}else if(elLoader=='12'){elLoaderAppend='<div class="css3-spinner-ball-scale-multiple"><div></div><div></div><div></div></div>';}else if(elLoader=='13'){elLoaderAppend='<div class="css3-spinner-ball-pulse-sync"><div></div><div></div><div></div></div>';}else if(elLoader=='14'){elLoaderAppend='<div class="css3-spinner-scale-ripple"><div></div><div></div><div></div></div>';}else{elLoaderAppend='<div class="css3-spinner-bounce1"></div><div class="css3-spinner-bounce2"></div><div class="css3-spinner-bounce3"></div>';}
if(!document.querySelector('.page-transition-wrap')){let divPT=document.createElement('div');divPT.classList.add('page-transition-wrap');divPT.innerHTML='<div class="css3-spinner" style="--cnvs-loader-color:var(--cnvs-themecolor);">'+elLoaderAppend+'</div>';SEMICOLON.Core.getVars.elBody.prepend(divPT);}else{pageTransition.innerHTML='<div class="css3-spinner">'+elLoaderAppend+'</div>';}
pageTransition=document.querySelector('.page-transition-wrap');pageTransition.classList.add('op-ts','op-1');setTimeout(()=>{pageTransition.classList.remove('op-1');pageTransition.classList.add('op-0');pageTransition.ontransitionend=pageTransition.onanimationend=()=>pageTransition.remove();},3000);};});cnvsSwitcherPrimaryFont.addEventListener('change',()=>{let fontID='cnvs-switcher-custom-primary-font';document.getElementById(fontID)?.remove();document.documentElement.style.removeProperty('--cnvs-primary-font');if(cnvsSwitcherPrimaryFont.value){let fontProps=JSON.parse(cnvsSwitcherPrimaryFont.value);SEMICOLON.Core.loadCSS({file:'https://fonts.googleapis.com/css2?family='+fontProps[0]+'&display=swap',id:fontID});document.documentElement.style.setProperty('--cnvs-primary-font',fontProps[1]);}});cnvsSwitcherBodyFont.addEventListener('change',()=>{let fontID='cnvs-switcher-custom-body-font';document.getElementById(fontID)?.remove();document.documentElement.style.removeProperty('--cnvs-body-font');if(cnvsSwitcherBodyFont.value){let fontProps=JSON.parse(cnvsSwitcherBodyFont.value);SEMICOLON.Core.loadCSS({file:'https://fonts.googleapis.com/css2?family='+fontProps[0]+'&display=swap',id:fontID});document.documentElement.style.setProperty('--cnvs-body-font',fontProps[1]);}});cnvsSwitcherEl.addEventListener('shown.bs.offcanvas',e=>{if(!cnvsSwitcherNicheDemos.classList.contains('cnvs-switcher-nichedemos-loaded')){setTimeout(()=>{fetch('include/switcher-niche-demos.html').then(response=>{return response.text();}).then(html=>{cnvsSwitcherNicheDemos.innerHTML=html;SEMICOLON.Core.runContainerModules(cnvsSwitcherNicheDemos);cnvsSwitcherNicheDemos.classList.add('cnvs-switcher-nichedemos-loaded');document.querySelector('.cnvs-switcher-niche-demos-preloader')?.remove();}).catch(err=>{console.log(err);});},1666);}});(function(){var cnvsTips=[{"title":"Did you know?","content":"You can enable Page Transition across the Website by simply changing the <code>Page Transition</code> value to <strong>true</strong> in the JS File.","page":"*"},{"title":"Looking for Form Auto-Responders?","content":"Canvas includes Auto-Responders for Forms which are personlization enabled.","page":"*"},{"title":"Anywhere Mobile-Menus!","content":"Enable Mobile Menus on any Device Width by defining a Custom Menu Breakpoint.","page":"*"},{"title":"SPAM Protection","content":"Canvas's Forms comes with multiple layers of SPAM Protection like Bot Detection, reCaptcha, hCaptcha or SPAM Word detection.","page":"*"},{"title":"Powerful CSS Variables","content":"Canvas is built using powerful CSS Variables across the Stylesheet. Easily Customize each and every part of your Website with just a handful of codes. No overwrites and bloated Custom CSS Codes.","page":"*"},{"title":"Dark-Mode on Demand","content":"Enable Dark Mode for any Section/Element on any Page using Our Powerful <a href='https://docs.semicolonweb.com/docs/utility-classes/contrast/' target='_blank'>Contrast Utility Classes</a>.","page":"*"},{"title":"Powerful Form Processor","content":"Convert any Form into a Working Email Form. No need to edit any Backend Codes. Just add your Form Fields and that's enough!","page":"*"},{"title":"<i class='bi-lightning-charge me-1'></i> Supreme Page Performance!","content":"Canvas comes with Async JS Lazy Loading which makes the Pages load Super Fast! Check the <a href='https://pagespeed.web.dev/report?url=https%3A%2F%2Fcanvastemplate.com%2Fdemo-app-landing.html&form_factor=desktop' target='_blank'>Google Page Speed</a> on our Live Demos with Async JS Enabled.","page":"*"},{"title":"Unlimited &amp; Easy Colors Management","content":"Change the Color Scheme of your Website with just one line of code.","page":"*"},];var randomIndex=Math.floor(Math.random()*cnvsTips.length);var randomTip=cnvsTips[randomIndex];var cnvsTipTitle=document.getElementById('cnvs-tips-element-title');var cnvsTipContent=document.getElementById('cnvs-tips-element-content');cnvsTipTitle.innerHTML=randomTip.title;cnvsTipContent.innerHTML=randomTip.content;setTimeout(function(){SEMICOLON.Modules.notifications(document.getElementById('cnvs-tips-element'));},Math.floor(Math.random()*5000));})();};if(typeof bootstrap!=='undefined'){cnvsCustomizer();}else{window.addEventListener('pluginBootstrapReady',()=>{cnvsCustomizer();});}