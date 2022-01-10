$(document).ready(() => {
    $("#searchForm").on("submit", (e) =>{
        
        let searchText = $("#searchText").val();
        getMovies(searchText);

        e.preventDefault();
    });
});

//`http://www.omdbapi.com?s=${searchText}`
//"http://www.omdbapi.com?s=+searchText"
//`http://www.omdbapi.com/?t=home`
//http://www.omdbapi.com/?i=tt3896198&apikey=93974bd3
//http://www.omdbapi.com/?apikey=[93974bd3]&s=${searchText}
//

function getMovies(searchText) {
     axios.get(`http://www.omdbapi.com/?s=${searchText}&apikey=93974bd3`)
     .then(function(res) {
         let movies = res.data.Search;
         console.log(movies);
         let output = '';
         $.each(movies, function (index, movie){
            output += `
                <div class="col-md-3">
                    <div class="well text-center">
                        <img src="${movie.Poster}">
                        <h5>${movie.Title}</h5>
                        <a onclick="movieSelected('${movie.imdbID}')" 
                            class="btn btn-primary href="#">Movie Details</a>
                    </div>
                </div>
            `;
         });
         $("#movies").html(output);
     })
     .catch(function(err){
        console.log(err)
     });
}

function movieSelected(id) {
    sessionStorage.setItem("movieId", id);
    window.location = "movie.html";
    return false;
}

function getMovie() {
    let movieId = sessionStorage.getItem("movieId");

    axios.get(`http://www.omdbapi.com/?i=${movieId}&apikey=93974bd3`)
    .then(function(res) {
        console.log(res);
        let movie = res.data;

        let output = `
            <div class="row">
                <div class="col-md-4">
                    <img src="${movie.Poster}">
                </div>
                <div class="col-md-8">
                    <h2>${movie.Title}</h2>
                        <ul>
                            <li class="list-group-item"><strong>Genre: </strong>${movie.Genre}</li>
                            <li class="list-group-item"><strong>Released: </strong>${movie.Released}</li>
                            <li class="list-group-item"><strong>Rated: </strong>${movie.Rated}</li>
                            <li class="list-group-item"><strong>IMDB Rating: </strong>${movie.imdbRating}</li>
                            <li class="list-group-item"><strong>Director: </strong>${movie.Director}</li>
                            <li class="list-group-item"><strong>Writer: </strong>${movie.Writer}</li>
                            <li class="list-group-item"><strong>Actors: </strong>${movie.Actors}</li>
                        </ul>
                </div>

            </div>
            <div class="row">
                <div class="well">
                    <h3>Plot</h3>
                    ${movie.Plot}
                    <hr/>
                    <a href="http://imdb.com/title/${movie.imdbID}"
                        target="_blank" class="btn btn-primary">View Movie</a>
                    <a href="index.html" class="btn btn-default">Go back to Search</a>
                </div>
            </div>
        `;
        $("#movie").html(output);
    })
    .catch(function(err){
       console.log(err)
    });
}