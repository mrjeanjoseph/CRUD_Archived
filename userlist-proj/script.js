// user class
class User {
    constructor(id, name, location) {
        this.id = id;
        this.name = name;
        this.location = location;
    }
}

// UI classes
class UI {
    static displayUsers(){
        const storedUsers = [
            {
                id: 1,
                name: "Veleenah",
                location: "Florence, Italy",
            },
            {
                id: 2,
                name: "Devereaux",
                location: "Paris, France",
            },
        ];
        const users = storedUsers;
        users.forEach(function(user) {
            UI.addUserToList(user)
        });
    }

    // static createHeader() {
    //     const headerElement = document.querySelector("#hearder-element");

    //     const hearderRow = document.createElement('tr');
    //     hearderRow.innerHTML = `
    //     <th scope="col">ID</th>
    //     <th scope="col">Name</th>
    //     <th scope="col">Location</th>
    //     <th scope="col"></th>
    //     `;
    //     headerElement.appendChild(hearderRow);
    // }

    static addUserToList(user) {
        const list = document.querySelector("#user-list");
        const row = document.createElement('tr');

        row.innerHTML = `
        <td>${user.id}</td>
        <td>${user.name}</td>
        <td>${user.location}</td>
        <td><a href="#" class="btn btn-danger btn-sm delete">x</a></td>
        `;
        
        list.appendChild(row);
    }
}
// Event to display users
document.addEventListener("DOMContentLoaded", UI.displayUsers);

// Event to add a new user
document.querySelector("#user-form").addEventListener("submit", function(e) {
    e.preventDefault();
    
    const id = document.querySelector("#id").value;
    const name = document.querySelector("#name").value;
    const location = document.querySelector("#location").value;

    //instentiate user form
    const user = new User(id, name, location);
    
    // add user to table
    UI.addUserToList(user);
});

// Event to remove user