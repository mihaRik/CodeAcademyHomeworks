
let jsonData;
$("#send").click(function(){
    let data=$("#name").val();
    let obj={
        name:data
    }
    jsonData=JSON.stringify(obj);
    console.log(jsonData)
})

$.ajax({
    url: "http://127.0.0.1:8080/data.json",
    type: "POST ",
    contentType: "application/json",
    crossDomain: true,
    dataType: "json",
    data: [jsonData],
    success: function (data) {
        console.log("data",data)
    },
    error: function (error) {
        console.log("error:",error)
    }
});