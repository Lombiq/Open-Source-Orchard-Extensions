(function(b){b.fn.getTwitter=function(h){b.fn.getTwitter.defaults={userName:null,numTweets:5,loaderText:"Loading tweets...",slideIn:true,slideDuration:750,showHeading:true,headingText:"Latest Tweets",showProfileLink:true,showTimestamp:true,includeRetweets:false,excludeReplies:true};var f=b.extend({},b.fn.getTwitter.defaults,h);return this.each(function(){var c=b(this);c.hide().empty().addClass("twitted");if(f.showHeading){c.append("<h2>"+f.headingText+"</h2>")}var k='<ul id="twitter_update_list"></ul>';c.append(k);var l=b("#twitter_update_list");l.hide();var d=b('<p class="preLoader">'+f.loaderText+"</p>");c.append(d);if(f.showProfileLink){var e='<p class="profileLink"><a href="https://twitter.com/'+f.userName+'">https://twitter.com/'+f.userName+"</a></p>";c.append(e)}c.show();window.jsonTwitterFeed="https://api.twitter.com/1/statuses/user_timeline.json?include_rts="+f.includeRetweets+"&excludeReplies="+f.excludeReplies+"&screen_name="+f.userName+"&count="+(f.numTweets+20);b.ajax({url:jsonTwitterFeed,data:{},dataType:"jsonp",callbackParameter:"callback",timeout:50000,success:function(i){window.count=0;b.each(i,function(p,q){var r="<li><span>"+a(q.text)+"</span>";if(f.showTimestamp){r+=' <a style="font-size:85%" href="https://twitter.com/'+f.userName+"/statuses/"+q.id_str+'">'+g(q.created_at)+"</a>"}r+="</li>";b("#twitter_update_list").append(r);count++;if(count==f.numTweets){b(d).remove();if(f.slideIn){var j=l.data("originalHeight");if(!j){j=l.show().height();l.data("originalHeight",j);l.hide().css({height:0})}l.show().animate({height:j},f.slideDuration)}else{l.show()}l.find("li:first").addClass("firstTweet");l.find("li:last").addClass("lastTweet");return false}})},error:function(n,i,j){}})});function a(c){var d=/(\b(https?|ftp|file):\/\/[-A-Z0-9+&@#\/%?=~_|!:,.;]*[-A-Z0-9+&@#\/%=~_|])/ig;return c.replace(d,'<a href="$1">$1</a>')}function g(e){var k=e.split(" ");e=k[1]+" "+k[2]+", "+k[5]+" "+k[3];var l=Date.parse(e);var d=(arguments.length>1)?arguments[1]:new Date();var c=parseInt((d.getTime()-l)/1000);c=c+(d.getTimezoneOffset()*60);if(c<60){return"less than a minute ago"}else{if(c<120){return"about a minute ago"}else{if(c<(60*60)){return(parseInt(c/60)).toString()+" minutes ago"}else{if(c<(120*60)){return"about an hour ago"}else{if(c<(24*60*60)){return"about "+(parseInt(c/3600)).toString()+" hours ago"}else{if(c<(48*60*60)){return"1 day ago"}else{return(parseInt(c/86400)).toString()+" days ago"}}}}}}}}})(jQuery);