select    ArticlesSet.IdArticles , 
		  ArticlesSet.Référence, 
		  ArticlesSet.Couleur , 
		  Sous_CatégoriesSet.Type_Sous_Catégorie,
		  CommandesSet.IdCommande,
		  FournisseursSet.IdFournisseurs,
		  FournisseursSet.Nom 
From    ArticlesSet,  Sous_CatégoriesSet,   CommandesSet, CatégoriesSet ,    FournisseursSet  
Where    ArticlesSet.Catégories_IdCatégories= CatégoriesSet.IdCatégories  
	AND  CatégoriesSet.IdCatégories=3  
	AND  CatégoriesSet.IdCatégories=Sous_CatégoriesSet.Catégories_IdCatégories  
	AND  ArticlesSet.Commandes_IdCommande=CommandesSet.IdCommande  
	AND  CommandesSet.Fournisseurs_IdFournisseurs= FournisseursSet.IdFournisseurs;



	select    Count(*) As Somme  from ArticlesSet where Catégories_IdCatégories=3 ;

	


	