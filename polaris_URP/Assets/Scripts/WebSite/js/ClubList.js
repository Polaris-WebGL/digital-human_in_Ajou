function checkOnlyOne(element) {

    const checkboxes
        = document.getElementsByName("week");

    checkboxes.forEach((cb) => {
        cb.checked = false;
    })

    element.checked = true;
}


/*var first = document.getElementById("first");
var second = document.getElementById("second");
var third = document.getElementById("third");
function firstpage(){
    if(first.css("display") == "none"){
        first.show();
        second.hide();
        third.hide();
    }
}
function secondpage(){
    if(second.css("display") == "none") {
        first.hide();
        second.show();
        third.hide();
    }
}
function thirdpage(){
    if(third.css("display") == "none") {
        first.hide();
        second.hide();
        third.show();
    }
}*/

/*
$(document).ready(function (){
    $("select").click(function(){
        update: function (){
            /!*var data = {
                
            }*!/
            
            $.ajax({
                url: "/api/v1/posts/",
                type: "get",
                dataType: 'json',
                contentType:'application/json; charset=utf-8',
                success: function (data) {
                    var json = JSON.parse(data.trim());

                    $('#club1 #club_img').append(value);
                    $('#club1 #club_intro').val() = json.club_intro;
                    $('#club1 #club_name').val() = json.club_name;
                    $('#club1 #club_activity').val() = json.club_activity;
                    $('#club1 #club_week').val() = json.club_week;
                    $('#club1 #club_sns_link').val() = json.club_sns_link;

                    $('#club2 #club_img').val() = json.club_img;
                    $('#club2 #club_intro').val() = json.club_intro;
                    $('#club2 #club_name').val() = json.club_name;
                    $('#club2 #club_activity').val() = json.club_activity;
                    $('#club2 #club_week').val() = json.club_week;
                    $('#club2 #club_sns_link').val() = json.club_sns_link;

                    $('#club3 #club_img').val() = json.club_img;
                    $('#club3 #club_intro').val() = json.club_intro;
                    $('#club3 #club_name').val() = json.club_name;
                    $('#club3 #club_activity').val() = json.club_activity;
                    $('#club3 #club_week').val() = json.club_week;
                    $('#club3 #club_sns_link').val() = json.club_sns_link;

                    $('#club4 #club_img').val() = json.club_img;
                    $('#club4 #club_intro').val() = json.club_intro;
                    $('#club4 #club_name').val() = json.club_name;
                    $('#club4 #club_activity').val() = json.club_activity;
                    $('#club4 #club_week').val() = json.club_week;
                    $('#club4 #club_sns_link').val() = json.club_sns_link;

                    $('#club5 #club_img').val() = json.club_img;
                    $('#club5 #club_intro').val() = json.club_intro;
                    $('#club5 #club_name').val() = json.club_name;
                    $('#club5 #club_activity').val() = json.club_activity;
                    $('#club5 #club_week').val() = json.club_week;
                    $('#club5 #club_sns_link').val() = json.club_sns_link;

                    $('#club6 #club_img').val() = json.club_img;
                    $('#club6 #club_intro').val() = json.club_intro;
                    $('#club6 #club_name').val() = json.club_name;
                    $('#club6 #club_activity').val() = json.club_activity;
                    $('#club6 #club_week').val() = json.club_week;
                    $('#club6 #club_sns_link').val() = json.club_sns_link;

                    $('#club7 #club_img').val() = json.club_img;
                    $('#club7 #club_intro').val() = json.club_intro;
                    $('#club7 #club_name').val() = json.club_name;
                    $('#club7 #club_activity').val() = json.club_activity;
                    $('#club7 #club_week').val() = json.club_week;
                    $('#club7 #club_sns_link').val() = json.club_sns_link;

                    $('#club8 #club_img').val() = json.club_img;
                    $('#club8 #club_intro').val() = json.club_intro;
                    $('#club8 #club_name').val() = json.club_name;
                    $('#club8 #club_activity').val() = json.club_activity;
                    $('#club8 #club_week').val() = json.club_week;
                    $('#club8 #club_sns_link').val() = json.club_sns_link;

                    $('#club9 #club_img').val() = json.club_img;
                    $('#club9 #club_intro').val() = json.club_intro;
                    $('#club9 #club_name').val() = json.club_name;
                    $('#club9 #club_activity').val() = json.club_activity;
                    $('#club9 #club_week').val() = json.club_week;
                    $('#club9 #club_sns_link').val() = json.club_sns_link;
                },
                error: function() {
                    alert('error');
                }
            });
        }
    });
});*/

