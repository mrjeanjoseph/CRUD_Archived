$.ajax({
    type: 'GET',
    url: "api/todos",
    // success: function(data){
    //     console.log("success", data)
    // }
}).then(function(data) {
    // console.log("std - success", data)
    for(const id in data) {
        if(id === 'nextid') return;
        console.log(data[id].title)
    }
})
