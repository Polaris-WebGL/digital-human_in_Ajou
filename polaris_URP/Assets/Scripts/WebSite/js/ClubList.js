function checkbox(){
    var flag = false;
    var values = document.getElementsByName("week");
    
    for(var i=0; i<values.length; i++){
        if(values[i].checked){
            alert(values[i].value);
            //각 value의 내용 출력하는 코드 작성
        }
    }
    
    return flag;
}