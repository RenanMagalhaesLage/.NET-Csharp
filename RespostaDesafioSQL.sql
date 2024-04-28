-- 1)Buscar o nome e o ano dos filmes
SELECT Nome, Ano FROM filmes;

-- 2)Buscar o nome e ano dos filmes, ordenados por ordem crescente pelo ano
SELECT Nome, Ano FROM filmes ORDER BY Ano ASC;

-- 3)Buscar pelo filme de volta para o futuro, trazendo o nome, ano e a duração
SELECT Nome, Ano, Duracao FROM filmes WHERE Nome = 'De Volta para o Futuro';

-- 4)Buscar os filmes lançados em 1997
SELECT * FROM filmes WHERE Ano = '1997';

-- 5)Buscar os filmes lançados APÓS o ano 2000
SELECT * FROM filmes WHERE Ano > '2000';

-- 6)Buscar os filmes com a duracao maior que 100 e menor que 150, ordenando pela duracao em ordem crescente
SELECT * FROM filmes WHERE Duracao > '100' AND Duracao < '150' ORDER BY Duracao ASC;

-- 7)Buscar a quantidade de filmes lançadas no ano, agrupando por ano, ordenando pela duracao em ordem decrescente
SELECT Ano, COUNT(*) AS Quantidade FROM filmes GROUP BY Ano ORDER BY Quantidade DESC;

-- 8) Buscar os Atores do gênero masculino, retornando o PrimeiroNome, UltimoNome
SELECT PrimeiroNome, UltimoNome FROM atores WHERE Genero = 'M';

-- 9)Buscar os Atores do gênero feminino, retornando o PrimeiroNome, UltimoNome, e ordenando pelo PrimeiroNome

-- 10)Buscar o nome do filme e o gênero
SELECT f.Nome AS Nome, g.Genero AS Genero FROM filmes f JOIN filmesgenero fg ON f.Id = fg.IdFilme JOIN generos g ON fg.IdGenero = g.Id;

-- 11) Buscar o nome do filme e o gênero do tipo "Mistério"
SELECT f.Nome AS Nome, g.Genero AS Genero FROM filmes f JOIN filmesgenero fg ON f.Id = fg.IdFilme JOIN generos g ON fg.IdGenero = g.Id WHERE g.Genero = 'Mistério';

-- 12)Buscar o nome do filme e os atores, trazendo o PrimeiroNome, UltimoNome e seu Papel
SELECT f.Nome AS Nome, a.PrimeiroNome AS PrimeiroNome, a.UltimoNome AS UltimoNome, ef.Papel AS Papel FROM filmes f JOIN elencofilme ef ON f.Id = ef.IdFilme JOIN atores a ON ef.IdAtor = a.Id