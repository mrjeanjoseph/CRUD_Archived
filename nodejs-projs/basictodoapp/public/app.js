$.ajax({
    type: 'GET',
    url: "api/todos",
    // success: function(data){
    //     console.log("success", data)
    // }
}).then(function (data) {
    // console.log("std - success", data);
    const count = 0;
    for (const id in data) {
        //count++;
        if (id === "nextid") return "";
        // console.log(data[id].title)
        // console.log(count);

        $("body").append(`
            <div>
                <h3>${data[id].title}</h3>
                <p>${data[id].content}</p>
            </div>
        `);

        $("body").append("Hello")
    }
})

$("#add-items").click(function (e) {
    e.preventDefault();
    const getTitle = $("#add-title").val();
    const getContent = $("#add-content").val();

    console.log({ getTitle, getContent })

    $("#add-title").val("");
    $("#add-content").val("");

})