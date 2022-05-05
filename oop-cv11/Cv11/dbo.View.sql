CREATE VIEW [dbo].[StudentCountView]
	AS SELECT Nazev, COUNT(IdStudent) as StudentCount FROM Predmet p JOIN StudentPredmet sp on p.Zkratka = sp.ZkratkaPredmet GROUP BY Nazev
