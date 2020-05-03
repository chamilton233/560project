--DECLARE @TeamPlayerStaging TABLE
--(
--   TeamId INT NOT NULL,
--   FistName NVARCHAR(32) NOT NULL,
--   LastName NVARCHAR(64) NOT NULL,
--   JerseyNum INT NOT NULL,
--   Position NVARCHAR(32)
--);

/***************************** Modify values here *****************************/

INSERT Basketball.TeamPlayer(TeamId, FirstName, LastName, JerseyNum, Position)
VALUES   
 (4, N'Kuame', N'Pearson', 76, N'G'),
(9, N'Vincent', N'Bruce', 23, N'G'),
(5, N'Alfonso', N'Kelly', 61, N'C'),
(2, N'Barrett', N'Ruiz', 73, N'F'),
(10, N'Hector', N'Cleveland', 91, N'F'),
(5, N'Elvis', N'Buckley', 28, N'C'),
(6, N'Fritz', N'Rutledge', 95, N'G'),
(1, N'Lewis', N'Small', 62, N'C'),
(10, N'Dylan', N'Hicks', 41, N'C'),
(9, N'Emery', N'Nielsen', 6, N'G'),
(5, N'Sylvester', N'Boyd', 31, N'G'),
(2, N'Gray', N'Rhodes', 89, N'C'),
(3, N'Yoshio', N'Velazquez', 92, N'F'),
(1, N'Oliver', N'Mcfadden', 13, N'G'),
(5, N'Price', N'Matthews', 91, N'F'),
(7, N'Walter', N'Mckinney', 57, N'F'),
(10, N'Hayden', N'Parrish', 6, N'G'),
(7, N'Jelani', N'Nolan', 30, N'F'),
(9, N'Joel', N'Bishop', 80, N'G'),
(7, N'Axel', N'Clay', 55, N'C'),
(2, N'Wyatt', N'Whitfield', 71, N'C'),
(5, N'Vance', N'Roth', 0, N'C'),
(2, N'Colt', N'Burnett', 57, N'C'),
(6, N'Jordan', N'Daniels', 63, N'F'),
(10, N'James', N'Roberson', 62, N'G'),
(3, N'Edan', N'Garrison', 63, N'F'),
(10, N'Avram', N'Mayo', 80, N'G'),
(4, N'Hall', N'Gallagher', 72, N'G'),
(8, N'Graham', N'Cortez', 59, N'F'),
(9, N'Zachery', N'Mullen', 84, N'G'),
(8, N'Quentin', N'Barnes', 90, N'F'),
(6, N'Ryder', N'Glenn', 65, N'G'),
(2, N'Rafael', N'Montoya', 57, N'F'),
(6, N'Malachi', N'Collier', 27, N'G'),
(8, N'Ryder', N'Mclaughlin', 3, N'F'),
(6, N'Declan', N'Padilla', 87, N'F'),
(3, N'Gannon', N'Freeman', 43, N'F'),
(5, N'Marsden', N'Melton', 93, N'F'),
(4, N'Driscoll', N'Copeland', 89, N'G'),
(2, N'Rigel', N'Cobb', 52, N'F'),
(4, N'Cooper', N'Weaver', 61, N'C'),
(10, N'Louis', N'Hester', 51, N'F'),
(3, N'Flynn', N'Sherman', 61, N'G'),
(8, N'Leonard', N'Bryant', 45, N'G'),
(8, N'Hashim', N'Mullins', 18, N'F'),
(3, N'Dale', N'Hebert', 50, N'F'),
(4, N'Ivan', N'Logan', 96, N'C'),
(5, N'Hilel', N'Huber', 6, N'G'),
(4, N'Keaton', N'Jacobson', 98, N'C'),
(2, N'Zeus', N'Shepherd', 35, N'C'),
(9, N'Tyrone', N'Wells', 37, N'F'),
(9, N'Blaze', N'Travis', 20, N'G'),
(10, N'Ivan', N'Nixon', 9, N'C'),
(1, N'Tate', N'Sharpe', 10, N'F'),
(10, N'Charles', N'Davis', 42, N'C'),
(2, N'Carlos', N'Rodriquez', 50, N'G'),
(8, N'Lester', N'Ballard', 60, N'G'),
(3, N'Marsden', N'Meadows', 50, N'G'),
(4, N'Galvin', N'Skinner', 50, N'G'),
(2, N'Perry', N'Walters', 87, N'C'),
(8, N'Brady', N'Donovan', 78, N'F'),
(9, N'Derek', N'Padilla', 66, N'F'),
(6, N'David', N'Sullivan', 82, N'G'),
(7, N'Hammett', N'Jordan', 95, N'G'),
(1, N'Myles', N'Gallagher', 5, N'C'),
(1, N'Brock', N'Slater', 94, N'F'),
(4, N'Amos', N'Cabrera', 46, N'G'),
(3, N'Tucker', N'Hinton', 41, N'F'),
(6, N'Mannix', N'Raymond', 65, N'F'),
(6, N'Carlos', N'Lee', 54, N'F'),
(1, N'Emmanuel', N'Cohen', 69, N'C'),
(8, N'Jacob', N'Price', 66, N'F'),
(3, N'Christian', N'Glover', 34, N'G'),
(5, N'Yoshio', N'Arnold', 78, N'F'),
(2, N'Fletcher', N'Lewis', 83, N'F'),
(7, N'Calvin', N'Camacho', 17, N'G'),
(2, N'Graiden', N'Hicks', 61, N'G'),
(5, N'Sean', N'Melendez', 25, N'F'),
(3, N'Oleg', N'Vinson', 62, N'G'),
(6, N'Nicholas', N'Mullen', 29, N'G'),
(8, N'Acton', N'Le', 56, N'G'),
(10, N'Howard', N'Harvey', 74, N'F'),
(5, N'Tucker', N'Fletcher', 88, N'C'),
(2, N'Brady', N'Gardner', 68, N'C'),
(3, N'Marshall', N'Olsen', 84, N'F'),
(1, N'Ezra', N'Guerrero', 38, N'C'),
(3, N'Ryan', N'Frank', 92, N'C'),
(1, N'Daniel', N'Weber', 51, N'C'),
(5, N'Hakeem', N'Beach', 87, N'G'),
(10, N'Holmes', N'Pace', 87, N'C'),
(10, N'Dalton', N'Dean', 3, N'F'),
(4, N'Brenden', N'Sargent', 43, N'G'),
(1, N'Xenos', N'Heath', 34, N'C'),
(6, N'Dieter', N'Byers', 35, N'F'),
(9, N'Barrett', N'Gregory', 86, N'G'),
(5, N'Lester', N'Serrano', 58, N'F'),
(6, N'Murphy', N'Drake', 31, N'C'),
(1, N'Noah', N'Maynard', 79, N'G'),
(7, N'Erich', N'Hurley', 7, N'F'),
(7, N'Kevin', N'Peterson', 80, N'G')
;

/******************************************************************************/

--MERGE Basketball.TeamPlayer T
--USING @TeamPlayerStaging S ON S.FirstName = T.FirstName AND S.LastName = T.LastName
--WHEN MATCHED AND NOT EXISTS
--    (
--        SELECT S.TeamId, S.FirstName, S.LastName, S.JerseyNum, S.Position
--        INTERSECT
--        SELECT T.TeamId, T.FirstName, T.LastName, T.JerseyNum, T.Position
--    ) THEN
--   UPDATE
--   SET 
--        TeamId = S.TeamId,
--        FirstName = S.FirstName,
--        LastName = S.LastName,
--        JerseyNum = S.JerseyNum,
--        Position = S.Position
--WHEN NOT MATCHED THEN
--   INSERT(TeamId, FirstName, LastName, JerseyNum, Position)
--   VALUES(S.TeamId, S.FirstName, S.LastName, S.JerseyNum, S.Position);
