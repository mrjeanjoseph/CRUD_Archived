

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
                // notice I am using the success function to get response back.
                console.log(response);
                $("#todo-container").empty();
                fetchAndDisplay();
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
        success: function (data) {
            for (const id in data) {
                if (id === "nextid") return "";

                const deleteBtn = $('<button>Delete Item</button>').click(function(){
                    console.log(id)
                })

                const appendTitleAndContent = $(`
                    <div>
                        <h3>${parseInt(id) + 1}: ${data[id].title}</h3>
                        <p>${data[id].content}</p>
                    </div>
                `);
                appendTitleAndContent.appendTo("#todo-container")
                deleteBtn.appendTo("h3")
                // .append(deleteBtn);

            }
        }
    })
    //.then(function (data) {
    //$("#todo-container").empty();
    // console.log("std - success", data);


    //})
}