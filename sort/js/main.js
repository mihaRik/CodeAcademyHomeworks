let studentArr = [];

function Student(name, age, group) {
    this.name = name;
    this.age = age;
    this.group = group;
    studentArr.push(this);
}

function getData() {
    let newStudent = new Student(
        $("#name").val(),
        Number($("#age").val()),
        $("#group").val()
    )
    return newStudent;
}
$("#getData").click(addStudentToTable);

function addStudentToTable() {
    let student = getData();
    let row = document.createElement("tr");
    for (let property in student) {
        let col = document.createElement("td");
        col.innerHTML = student[property];
        $(row).append($(col));
    }
    $("#tableBody").append($(row));
}

// $(".sortName").click(function () {
//     let nameArr = [];
//     studentArr.forEach(function (value) {
//         nameArr.push(value.name)
//     })
//     let sortedName = nameArr.sort()
//     studentArr.forEach(function (value) {
//         for (let i = 0; i < nameArr.length; i++) {
//             if (value.name == sortedName[i]) {
//                 let temp = studentArr[i].name;
//                 studentArr[i].name = sortedName[i];
//                 value.name = temp;
//             }
//         }
//     })
//     $("#tableBody").children().remove();
//     studentArr.forEach(function (value) {
//         let row = document.createElement("tr");
//         for (let property in value) {
//             let col = document.createElement("td");
//             col.innerHTML = value[property];
//             $(row).append($(col));
//         }
//         $("#tableBody").append($(row));
//     })
// })

// function sort(property) {
//     let arr = [];
//     studentArr.forEach(function (value) {
//         arr.push(value[property])
//     })
//     let sortedArr = arr.sort()
//     studentArr.forEach(function (value) {
//         for (let i = 0; i < arr.length; i++) {
//             if (value[property] == sortedArr[i]) {
//                 let temp = studentArr[i][property];
//                 studentArr[i][property] = sortedArr[i];
//                 value[property] = temp;
//             }
//         }
//     })
//     $("#tableBody").children().remove();
//     studentArr.forEach(function (value) {
//         let row = document.createElement("tr");
//         for (let property in value) {
//             let col = document.createElement("td");
//             col.innerHTML = value[property];
//             $(row).append($(col));
//         }
//         $("#tableBody").append($(row));
//     })
// }

$(".sortName").click(function () {
    sort("name")
});
$(".sortGroup").click(function () {
    sort("group")
});
$(".sortAge").click(function () {
    sort("age")
});

function sort(property) {
    let arr = [];
    studentArr.forEach(function (value) {
        arr.push(value[property])
    })
    let sortedArr = [];
    if (typeof (arr[0]) == "number") {
        sortedArr = arr.sort(function (a, b) {return a - b})
    } else {
        sortedArr = arr.sort()
    }
    studentArr.forEach(function (value) {
        for (let i = 0; i < arr.length; i++) {
            if (value[property] == sortedArr[i]) {
                for (let prop in studentArr[i]) {
                    let temp = studentArr[i][prop];
                    studentArr[i][prop] = value[prop];
                    value[prop] = temp;
                }
            }
        }
    })
    $("#tableBody").children().remove();
    studentArr.forEach(function (value) {
        let row = document.createElement("tr");
        for (let property in value) {
            let col = document.createElement("td");
            col.innerHTML = value[property];
            $(row).append($(col));
        }
        $("#tableBody").append($(row));
    })
}