select Sous_Cat�goriesSet.Type_Sous_Cat�gorie 
from Cat�goriesSet, Sous_Cat�goriesSet
Where Sous_Cat�goriesSet.Cat�gories_IdCat�gories= Cat�goriesSet.IdCat�gories
  AND Cat�goriesSet.IdCat�gories=3;

  select ArticlesSet.R�f�rence 
  From ArticlesSet, Cat�goriesSet
  Where ArticlesSet.Cat�gories_IdCat�gories=Cat�goriesSet.IdCat�gories
    And Cat�goriesSet.IdCat�gories= 3;



  select Sous_Cat�goriesSet.Type_Sous_Cat�gorie from Cat�goriesSet, Sous_Cat�goriesSet Where Sous_Cat�goriesSet.Cat�gories_IdCat�gories= Cat�goriesSet.IdCat�gories AND Cat�goriesSet.IdCat�gories=3;

 select distinct ArticlesSet.R�f�rence  From ArticlesSet, Cat�goriesSet Where ArticlesSet.Cat�gories_IdCat�gories=Cat�goriesSet.IdCat�gories  And Cat�goriesSet.IdCat�gories= 3;