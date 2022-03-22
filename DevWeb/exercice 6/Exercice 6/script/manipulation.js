
window.onload=InitialiserEvenements;

var nombres=[-1,-1,-1,-1,-1];

var minute=0;
var seconde=0;

function InitialiserEvenements()
{
	document.getElementById("boutonString").addEventListener("click", TraiterChaine);
	document.getElementById("boutonMath").addEventListener("click", TraiterMath);
	document.getElementById("boutonGenerer").addEventListener("click", Calculer);
	// DebuterChrono();
}

//exercice 1
function TraiterChaine()
{
	let cpt = 0;

	let phrase = document.getElementById("phrase").value;

	let phraseSansEspace = phrase.trim();
	
	let nombreEspaces = phrase.length - phraseSansEspace.length;


	document.getElementById("longueurChaine").innerHTML = "Votre phrase contient "+ phraseSansEspace.length +" caractères ";
	let Allo = phraseSansEspace.indexOf("Allo");
	
	document.getElementById("positionAllo").innerHTML = "Le mot Allo n'est pas présent dans la phrase";
	
	if(Allo >= 0){
		document.getElementById("positionAllo").innerHTML = "Votre phrase contient "+ "Allo" + " à la position : " + phrase.indexOf("Allo");
	}
	
	for(let i = 0; i < phraseSansEspace.length; i++){
		if(phraseSansEspace[i] == " "){
			cpt++;
		}
	}

	document.getElementById("nombreEspaces").innerHTML = "Votre phrase contient " + cpt + " Espace ";
	
	
	

}

//exercice 2
function TraiterMath()
{
	var N1,N2;

	/* ATTENTION
	Lorsqu'on concatène chaine et nombre: aussitôt qu'il y a une chaine alors la concaténation est faite sous forme de chaine. Exemples:
	1 + 2 donne 3
	"1" + "2" donne "12"
	1 + 2 + " allo" donne "3 allo"
	"allo " + 1 + 2 donne "allo 12"
	
	Lorsqu'on compare des chaines et des nombres: aussitôt qu'il y a un nombre alors la comparaison est faite comme des numériques. Exemples:
	11 < 3 donne false
	"11" < "3" donne true
	"11" < 3 donne false
	
	De plus:
	1 == "1" donne true
	1 === "1" donne false
	*/
	
}
//exercice 3
function Calculer()
{
	var cpt=0;
	var elements = document.querySelectorAll("#ex3 span");

	var unElement = document.querySelector("");

	var total=0;
	GenererNombres();
	for (cpt=0; cpt<elements.length; cpt++)
	{
		elements[cpt].innerHTML = nombres[cpt];
	}

}

 function GenererNombres()
 {
	var cpt=0;

 }

 function DebuterChrono() 
{
	setInterval("AfficherHeure()",1000);
}

function AfficherHeure()
{

}

