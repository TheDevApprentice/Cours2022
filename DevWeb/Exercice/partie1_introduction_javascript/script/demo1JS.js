
/* Lorsque la page html aura terminée de se charger (événement onload) 
	alors la fonction InitialiserEvenements s'exécutera */
window.onload = InitialiserEvenements;

/*.addEventListener permet de faire le lien entre un événement et la fonction à exécuter lorsque cet événement se produit*/
/*
	document.getElementById("message")
		permet d'utiliser l'élément dont le id est 'message' 
	addEventListener('click', AfficherMessage)
		click est le nom de l'événement
		AfficherNom est le nom de la fonction à exécuter
	==> lorsqu'un clic se produit sur l'élément 'message' il faut exécuter la fonction AfficherMessage 
*/
function InitialiserEvenements(){
	document.getElementById("message").addEventListener('click', AfficherMessage); 				
	document.getElementById("confirmation").addEventListener('click', DemanderConfirmation);
	document.getElementById("question").addEventListener('click', DemanderQuestion);
	document.getElementById("innerhtml").addEventListener('click', ExemplesInnerHtml);
	document.getElementById("nouvelleQuestion").addEventListener('click', AfficherQuestion);
	document.getElementById("reponse").addEventListener('click', DemanderReponse);
	document.getElementById("compteur").addEventListener('click', IncrementationClics);
}

//alert() permet de faire afficher un message dans une fenêtre 'popup'
function AfficherMessage()
{
	let day = new Date().getDate(); 
	let hours =  new Date().getHours(); 
	let minutes =   new Date().getMinutes(); 
	alert("Bonjour nous somme "+ day + " " + hours); 
}

//confirm() permet de poser une question  à l'aide d'un popup 
//donne 2 choix de réponses selon le navigateur: ok (retourne true) et annuler (retourne false)
function DemanderConfirmation()
{
	 var confirmation = false;
	 confirmation = confirm("Aimez-vous le html?");
	 if (confirmation==true)
	 {
		 alert("Bravo!!!");
	 }
	else{
		alert("Désolé pour vous...");
	}
}
let incrémentation = 0;
function IncrementationClics()
{

	incrémentation++;
	var paragraphe_message = document.getElementById("zone_click");
	paragraphe_message.innerHTML = "Nombre de clics "+ incrémentation ; 
}
//prompt permet de poser une question à l'aide d'un popup
//l'usager répond ce qu'il veut dans la zone de texte
//la réponse entrée par l'usager est assignée à une variable

//.innerHTML permet d'accéder au code html de l'élément
/* On peut l'utiliser pour
	- ajouter du code html, incluant de nouvelles balises
	- connaitre le code html existant dans la page
*/
function DemanderQuestion()
{
	//déclaration d'une variable: pas de type en javascript
	//préférable d'utiliser le mot 'var' pour la déclaration d'une variable
	//		(sinon, elle est considérée comme étant globale: mauvaise façon)
	var reponse = "";
	var paragraphe_message = document.getElementById("zone_message");
	while (reponse == null || reponse == "")
	{
		reponse = prompt("Quel est votre age");
	}
	paragraphe_message.innerHTML = "Vous êtes agé de: " + reponse + " ans";
}

function ExemplesInnerHtml()
{
	 //Exemple1();
	 //Exemple2();
	 Exemple3();
}

function Exemple1()
{
	//on peut ajouter du texte ET des balises
	var elementHtml = document.getElementById("zone_message");
	elementHtml.innerHTML = "<b>Ajout d'une balise pour mettre en gras</b></br> et d'une balise pour changer de ligne";
}
function Exemple2()
{
	//on peut ajouter plusieurs paragraphes
	var elementHtml = document.getElementById("div_message");
	elementHtml.innerHTML = "<p>Allo...</p>";
	elementHtml.innerHTML += "<p>Bonjour...</p>";
	elementHtml.innerHTML += "<p>Bonsoir...</p>";
	elementHtml.innerHTML += "<p>Bonne nuit...</p>";
}
function Exemple3()
{
	//on peut connaitre le contenu actuel
	var texte = "";
	var elementHtml = document.getElementById("zone_message");
	texte = elementHtml.innerHTML;
	if (texte == "")
	{
		elementHtml.innerHTML = "allo";
	}
	else if (texte=="allo")
	{
		elementHtml.innerHTML = "salut";
	}
	else {
		elementHtml.innerHTML = "allo";
	}
}

function AfficherQuestion()
{
	document.getElementById("texte_question").innerHTML = "Nom de la maladie causant la pandémie?";
}

function DemanderReponse()
{
	var reponse = prompt("Votre réponse...");
	if (reponse == "covid" || reponse=="COVID" || reponse=="covid19" || reponse=="COVID19")
	{
		document.getElementById("texte_reponse").innerHTML = "Vous avez trouvé!!!"
	}
	else {
		document.getElementById("texte_reponse").innerHTML = "Essayez encore..."
	}
}

