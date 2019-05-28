let jsonData;

let sendToJSON=new XMLHttpRequest();
sendToJSON.open("POST","data.json",true);
sendToJSON.setRequestHeader("Content-Type","application/json");

$("#send").click(function(){
    let data=$("#name").val();
    let obj={
        name:data
    }
    jsonData=JSON.stringify(obj);
    console.log(jsonData)
})
sendToJSON.send(`{"a":"dwd"}`)
