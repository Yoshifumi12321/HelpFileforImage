$(function() {
    $(document).click(function(event) {
    if(!$(event.target).closest('.item').length) {
      $('.itemset').hide();
      if(tag!='LI'){
        //Menu以外
        $('#'+id).css({
          'color':'#3f9f4b',
          'background-color':'transparent',
          'border':'none',
          'text-decoration': 'underline'
        });
      }
    }
  });

  var id;
  var tag;
  $('.item').on('click', function(event){
        var a =  $(this).attr('id');
        tag = $('#'+a+'ex').prop("tagName");
        var textlength = $('#'+a+'ex').text().length;
        console.log(tag);
        if(tag=="LI"){
          //Menuウィンドウのアニメーション設定
          if(id!= a){
            $('.itemset').hide();
          }
          id =  $(this).attr("id");
          $('#'+id+'ex').toggle();
          //id =  $(this).attr("id");
          if(textlength>40){
            $('#'+id+'ex').css('width','32em');
          }
        }
        else {

          //Menuウィンドウ以外の項目表示アニメーション設定
          if(id!= a){
            $('.itemset').hide();
            $('#'+id).css({
              'color':'#3f9f4b',
              'background-color':'transparent',
              'border':'none',
              'text-decoration': 'underline'
            });
          }
          id =  $(this).attr("id");
          var leftOffset = $('#'+id).offset().left;
          var topOffset =  $('#'+id).offset().top;
          $('#'+id+'ex').toggle(0,function(){
            if ($('#'+id+'ex').is(':visible')) {
              //text表示中の処理
              $('#'+id).css({
                'color':'white',
                'background-color':'#3677cf',
                'border':'thin solid black',
                'border-bottom':'none',
                'text-decoration': 'none'
              });
            }
            else{
              //text非表示中の処理
              $('#'+id).css({
                'color':'#3f9f4b',
                'background-color':'transparent',
                'border':'none',
                'text-decoration': 'underline'
              });
            }
          });
          $('#'+id+'ex').css({'left':leftOffset,'top':topOffset+5});
          if(textlength>20){
            $('#'+id+'ex').css('width','15em');
          }
          var $dir = location.href.split("/");
          var $dir2 = $dir[$dir.length -2];
          if($dir2=="Menu"){
            if(textlength>30){
              $('#'+id+'ex').css('width','25em');
            }
          }
        }
  });

  $(document).click(function(event) {
    if(!($(event.target).closest('.image').length||$(event.target).closest('.imageset').length)) {
      $('.imageset').hide();
    }
  });
  var targetElement = document.getElementById( "target" ) ;
  $('.image').on('click', function(event){
        var clientRect = targetElement.getBoundingClientRect();
        var y = clientRect.top ;
        var py = window.pageYOffset + clientRect.top ;// ページの上端から、要素の上端までの距離取得
        var a =  $(this).attr('id');
        //alert(py);
        if(id!= a){
          $('.imageset').hide();
        }
        id =  $(this).attr("id");
        $('#'+id+'ex').toggle();

        var textlength = $('#'+id+'ex').text().length;
        if(textlength>=70){
          $('#'+id+'ex').css('width','25em');
        }
        else if(textlength>=40){
          $('#'+id+'ex').css('width','15em');
        }
        else if(textlength>=20){
          $('#'+id+'ex').css('width','13em');
        }
        var pArray = $(this).attr("coords").split(",");
        $('#'+id+'ex').css({'top':Number(pArray[3])+py-13,'left':Number(pArray[0])+10});

        if(~id.indexOf('Block')){//idに'Block'が含まれている場合
          $('#'+id+'ex').css('width','14em');
          $('#'+id+'ex').css({'top':Number(pArray[3])+py,'left':Number(pArray[0])+10});
        }
  });


});
