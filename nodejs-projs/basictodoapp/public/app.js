

$("#myAppContainer").on({
    click: function (e) {
        e.preventDefault();
        const title = $("#add-title").val();
        const content = $("#add-content").val();
        // console.log({ getTitle, getContent })
        $.ajax({
            type: 'POST',
            url: '/api/todos',
            data: { title, content },
            success: function (response) {
                console.log(response);
            }
        })
        // .then(function (response) {
        //     console.log(response);
        // })

        $("#add-title").val("");
        $("#add-content").val("");
    }

}, '#add-items');

fetchAndDisplay();


function fetchAndDisplay() {
    $.ajax({
        type: 'GET',
        url: "api/todos",
        // success: function(data){
        //     console.log("success", data)
        // }
    }).then(function (data) {
        // console.log("std - success", data);
        
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
        }
    })
}