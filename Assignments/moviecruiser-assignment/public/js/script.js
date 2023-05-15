var movies="";
var favourites=[];

fetch('http://localhost:3000/movies')
.then(response=>response.json())
.then(data=>{console.log(data)
    movies = data;
    //  console.log(data.length);
	getMovies();

})
function getMovies() {
	var showmovies="";
    
    showmovies+= "";
    
	for(var i=0;i<movies.length;i++)
  {

	showmovies+= `  <div class="list-group-item d-flex flex-column align-items-center"> 
	<br><h4> ${movies[i].title}  </h4> <br>
	<img src=${movies[i].posterpath}><br>
	 <button onclick="addFavourite(${movies[i].id})" type="button" class="btn btn-primary">Add to Favourties</button>
	 </div>`;
 }
 document.getElementById("moviesList").innerHTML = showmovies;
 }

function getFavourites(movId) {
	console.log(movId);
	var objId = geMovieInfobyId()
  }
 
const geMovieInfobyId = (x) => {
	for(let i=0;i<movies.length;i++){
		if(x == movies[i].id) {
			console.log(movies[i]);
			return movies[i];
		}
	}
}
var favmovies="";
function addFavourite(movId) {
	
	console.log(movId);
	var movieObject = geMovieInfobyId(movId)
    var fav= favourites.find(y=>{
		if(y.id ==  movId){
			return y;
		}
	})
	if(fav){
		alert("Movie is already added in favourites");
	}else{
		console.log("post method")
		fetch("http://localhost:3000/favourites", 
		{ method: 'POST', 
		body: JSON.stringify(movieObject), 
		 headers: { "Content-type": "application/json" 
	   } }) .
		 then(response => response.json()) 
		 .then(data1 => {console.log(data1)
         	}
		 )
		}

}
function favmovielist(){

	fetch('http://localhost:3000/favourites')
	.then(response=>response.json())
	.then(data=> {
		favourites = data
		getFavourites();
	})
}

	function getFavourites()
	{
		console.log(favourites.length)
		 var showfavmovies="";
         console.log( favourites)
	for(var i=0;i<favourites.length;i++)
  {

	showfavmovies+= `<div class="list-group-item d-flex flex-column align-items-center">
	<br> <h4 > ${favourites[i].title}  </h4> <br>
	 <img src=${favourites[i].posterpath}>
	 <br><button onclick="deleteFavourites(${favourites[i].id})"type="button" class="btn btn-primary " >Remove from Favourties</button>
	 </div>`;
 }
 document.getElementById("favouritesList").innerHTML = showfavmovies;
}
 favmovielist();


	
 const deleteFavourites = (favId)=>{
     console.log(`${favId}deleted`)
	return fetch(`http://localhost:3000/favourites/${favId}`,
	{
	  method: 'DELETE', 
		 headers: { "Content-type": "application/json" }
	 } )
 }

// module.exports = {
// 	getMovies,
// 	getFavourites,
// 	addFavourite
// };

// You will get error - Uncaught ReferenceError: module is not defined
// while running this script on browser which you shall ignore
// as this is required for testing purposes and shall not hinder
// it's normal execution