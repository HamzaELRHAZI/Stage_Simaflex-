select Sous_CatégoriesSet.Type_Sous_Catégorie 
from CatégoriesSet, Sous_CatégoriesSet
Where Sous_CatégoriesSet.Catégories_IdCatégories= CatégoriesSet.IdCatégories
  AND CatégoriesSet.IdCatégories=3;

  select ArticlesSet.Référence 
  From ArticlesSet, CatégoriesSet
  Where ArticlesSet.Catégories_IdCatégories=CatégoriesSet.IdCatégories
    And CatégoriesSet.IdCatégories= 3;



  select Sous_CatégoriesSet.Type_Sous_Catégorie from CatégoriesSet, Sous_CatégoriesSet Where Sous_CatégoriesSet.Catégories_IdCatégories= CatégoriesSet.IdCatégories AND CatégoriesSet.IdCatégories=3;

 select distinct ArticlesSet.Référence  From ArticlesSet, CatégoriesSet Where ArticlesSet.Catégories_IdCatégories=CatégoriesSet.IdCatégories  And CatégoriesSet.IdCatégories= 3;