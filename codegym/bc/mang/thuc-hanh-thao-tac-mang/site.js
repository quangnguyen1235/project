let x=0;
let array= Array();
function add_element(){
    array[x]= document.getElementById("txtvalue").value;
    alert("phần tử "+ array[x] + " đã được gán vào vị trí " + x);
    x++;
    document.getElementById("txtvalue").value="";
}
function add_dislay(){
    let e= "<hr/>";
    for (let i=0; i<array.length; i++){
        e+= "element" + i + array[i] + "<br/>";
        document.getElementById("result").innerHTML=e;

    }
}