$(document).ready(function() {
    $("#searchuser").on("keyup", function(e) {
        let username = e.target.value;

        $.ajax({
            url: `https://api.github.com/users/${username}`,
            data:{
                client_id:'97817cfae14c918a7627',
                client_secret:'f88366bf476335eb9a9dd0e4343477464693f7cf'
            }
        }).done(function(user){
            $.ajax({
                url: `https://api.github.com/users/${username}/repos`,
                data:{
                    client_id:'97817cfae14c918a7627',
                    client_secret:'f88366bf476335eb9a9dd0e4343477464693f7cf'
                }
            }).done(function(repos) {

            });
            $("#profile").html(`
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">${user.name}</h3>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-md-3">
                            <img class="thumbnail avatar" src="${user.avatar_url}">
                            <a target="_blank" class="btn btn-primary btn-block" href="${user.html_url}">View Profile</a>
                        </div>
                        <div class="col-md-9">
                            <span class="badge rounded-pill bg-success">Public Repos: ${user.public_repos}</span>
                            <span class="badge rounded-pill bg-info text-dark">Public Gists:${user.public_gists}</span>
                            <span class="badge rounded-pill bg-primary">Followers:${user.followers}</span>
                            <span class="badge rounded-pill bg-dark">Following:${user.following}</span>
                            <br><br>
                            <ul class="list-group">
                            <li class="list-group-item">Github ID: ${user.id}</li>
                            <li class="list-group-item">Bio: ${user.bio}</li>
                            <li class="list-group-item">Company: ${user.company}</li>
                            <li class="list-group-item">Website/Blog: ${user.blog}</li>
                            <li class="list-group-item">Location: ${user.location}</li>
                            </ul>                            
                        </div>
                    </div>
                </div>
            </div>

            <h3 class="page-header">Latest Repos</h3>
            <div id="repos"></div>
            `)
        });
    });
});