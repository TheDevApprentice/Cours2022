window.onload = InitialiserEvenements;

function InitialiserEvenements()
{
	//exemple 1: changer le code HTML
	document.getElementById("changementHTML").addEventListener("click", ChangerHTML);

	//exemple 2: changer un attribut
	document.querySelector("#exemple2 button").addEventListener("click", ChangerAttribut);

	//exemple 3: changer CSS
	document.querySelector("#exemple3 button:first-of-type").addEventListener("click", FaireApparaitre);
	document.querySelector("#exemple3 button:nth-of-type(2)").addEventListener("click", ChangerBordure);

 	//exemple 4: accéder aux éléments à l'aide des balises
	 document.querySelector("#exemple4 button").addEventListener("click", AccederAvecBalise);
	 
 	//exemple 5: accéder aux éléments appartenant à une classe
 	document.querySelector("#exemple5 button").addEventListener("click", ChangerTexteParClass);
	
	 //exemple 6: accéder aux éléments à l'aide d'un sélecteur
	document.querySelector("#exemple6 button").addEventListener("click", ChangerTexte);

	//exemple 7: accéder aux éléments à l'aide d'un sélecteur
	var elements = document.querySelectorAll("#exemple7 button");
	for (var cpt=0; cpt<elements.length; cpt++)
	{
		elements[cpt].addEventListener("click", AfficherTexteBouton);
	}
}

var timerAjouterListe;
function ajouterListe() {
		document.querySelector("#exemple1 div").innerHTML 
		+= "<ul><li>item 1</li><li>item 2</li></ul>";
}

function annulerTimer() {
		clearInterval(timerAjouterListe);
}

//exemple 1
//javascript peut changer du contenu HTML en utilisant .innerHTML
//ici, on utilise un sélecteur css pour trouver les éléments à modifier: .querySelector
//ex: document.querySelector("#exemple1 p") 
// 		--> sélectionne la balise <p> dont le parent est l'élément portant le id exemple1
function ChangerHTML(){
	document.querySelector("#exemple1 p").innerHTML = "Allo tout le monde...";
	document.querySelector("#exemple1 div").innerHTML = "<h3>Liste d'éléments</h3>";
	timerAjouterListe = setInterval(ajouterListe, 1000);
	setTimeout(annulerTimer, 3000);
}

//exemple 2
//Une balise possède des attributs. Javascript peut changer ces attributs.
function ChangerAttribut() {
	var imageAChanger = document.getElementById("imageExemple2");
	//.alt représente l'attribut alt de la balise <img> que l'on vient de sélectionner
	//et on change les attributs src, alt, width et height
	//ce qui permet de changer l'image à l'écran
	if (imageAChanger.alt == "asterix") {
		imageAChanger.src = "images/obelix2.gif";
		imageAChanger.width ="75";
		imageAChanger.height ="108";
		imageAChanger.alt = "obelix";
	}
	else {
		imageAChanger.src = "images/asterix.jpg";
		imageAChanger.width ="97";
		imageAChanger.height ="97";
		imageAChanger.alt = "asterix";
	}
}

//exemple 3
//javascript peut changer des propriétés CSS
//pour changer une propriété css il faut utiliser .style.nom_de_la_propriété
//et la valeur que l'on donne à la propriété doit toujours être entre guillemets ""
//ex: .style.color = "red"; --> change la couleur du texte pour qu'il soit rouge

//il faut faire attention aux propriété formée de 2 mots comme background-color
//il faut plutôt écrire la propriété en UN SEUL MOT et débuter le 2ième mot par une majuscule
//ex: .style.backgroundColor = "red";
function FaireApparaitre()
{
	//ici la propriété display avec la valeur "none" permet de faire disparaître l'élément
	var image = document.querySelector("#exemple3 img");
	if (image.style.display == "none"){
		image.style.display = "block";
	}
	else {
		image.style.display = "none";
	}
}
function ChangerBordure()
{
	var image = document.querySelector("#exemple3 img");
	if (image.style.borderStyle == "solid"){
		image.style.borderStyle = "none";
	}
	else {
		image.style.borderStyle = "solid";
		image.style.borderColor = "red";
		image.style.borderWidth = "2px";
	}
}

//exemple 4: javascript peut trouver TOUS les éléments d'une balise particulière: getElementsByTagName (remarquez le S dans Elements)
//étant donné qu'il peut y avoir plusieurs fois la même balise dans une page alors plusieurs éléments sont trouvés
// et il faut les traiter à l'aide d'une boucle
//ici, on trouve tous les <h2> de la page
function AccederAvecBalise()
{
	var cpt;
	var balisesH2=document.getElementsByTagName("h2");
	//.length indique le nombre d'éléments qui se trouvent dans la variable balisesH2
	//pour manipuler UN élément en particulier, on utilise les [] comme pour accéder à un élément d'un tableau
	for (var cpt=0; cpt<balisesH2.length; cpt++)
	{
		if (cpt%2)
			balisesH2[cpt].style.color = "green";
		else
			balisesH2[cpt].style.color = "red";
	}
}

//exemple 5: javascript peut trouver tous les éléments appartenant à une classe particulière: getElementsByClassName
//encore une fois, plusieurs éléments sont trouvés et il faut les traiter avec une boucle
function ChangerTexteParClass(){
	var cpt=0;
	var elements=document.getElementsByClassName("demoClasse");		
	for (var cpt=0; cpt<elements.length; cpt++)
	{
		elements[cpt].style.backgroundColor = "lightgreen";
	}
}

//exemple 6: javascript peut trouver plusieurs éléments à l'aide d'un sélecteur: querySelectorAll
//un sélecteur css peut cibler plusieurs éléments, querySelectorAll peut donc trouver plusieurs éléments
//et on les traite avec une boucle
function ChangerTexte(){
	var cpt=0;
	var paragraphes=document.querySelectorAll("#exemple6 p");		
	for (var cpt=0; cpt<paragraphes.length; cpt++)
	{
		paragraphes[cpt].innerHTML = "Allooooooooooooooo";
	}
}


//exemple 7: 
//lorsque plusieurs éléments sont associés à la même fonction,
//il est possible de savoir quel élément a déclenché l'événement avec this
function AfficherTexteBouton()
{
	alert(this.innerHTML);
}