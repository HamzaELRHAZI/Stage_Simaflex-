select    ArticlesSet.IdArticles , 
		  ArticlesSet.R�f�rence, 
		  ArticlesSet.Couleur , 
		  Sous_Cat�goriesSet.Type_Sous_Cat�gorie,
		  CommandesSet.IdCommande,
		  FournisseursSet.IdFournisseurs,
		  FournisseursSet.Nom 
From    ArticlesSet,  Sous_Cat�goriesSet,   CommandesSet, Cat�goriesSet ,    FournisseursSet  
Where    ArticlesSet.Cat�gories_IdCat�gories= Cat�goriesSet.IdCat�gories  
	AND  Cat�goriesSet.IdCat�gories=3  
	AND  Cat�goriesSet.IdCat�gories=Sous_Cat�goriesSet.Cat�gories_IdCat�gories  
	AND  ArticlesSet.Commandes_IdCommande=CommandesSet.IdCommande  
	AND  CommandesSet.Fournisseurs_IdFournisseurs= FournisseursSet.IdFournisseurs;



	select    Count(*) As Somme  from ArticlesSet where Cat�gories_IdCat�gories=3 ;

	


	