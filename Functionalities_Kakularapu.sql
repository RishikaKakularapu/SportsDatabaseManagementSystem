USE SportsDatabaseManagementSystem;
GO

SELECT AVG(TRY_CAST(REPLACE(REPLACE(AthleteSalary, '$', ''), ',', '') AS DECIMAL(10, 2))) AS AverageAthleteSalary
FROM Athlete
WHERE TRY_CAST(REPLACE(REPLACE(AthleteSalary, '$', ''), ',', '') AS DECIMAL(10, 2)) IS NOT NULL;


SELECT COUNT(*) AS ExperiencedCoachesCount FROM Coach WHERE CoachExp > 7;


SELECT TournamentSportName, COUNT(*) AS TournamentCount
FROM Tournament
GROUP BY TournamentSportName;

SELECT * FROM Match WHERE MatchDuration > 2.0;

SELECT PlayerGen, AVG(PlayerWt) AS AverageWeight
FROM PLAYER
GROUP BY PlayerGen
HAVING AVG(PlayerWt) > 30;

SELECT
    Player.PlayerID,
    Player.PlayerFName,
    Player.PlayerLName,
    Team.TeamID,
    Team.TeamSportName
FROM
    Player
LEFT JOIN
    TeamComposition ON Player.PlayerID = TeamComposition.PlayerID
LEFT JOIN
    Team ON TeamComposition.TeamID = Team.TeamID;



SELECT
    Team.TeamID,
    Team.TeamSportName,
    AVG(Player.PlayerHt) AS AveragePlayerHeight
FROM
    Team
INNER JOIN
    TeamComposition ON Team.TeamID = TeamComposition.TeamID
INNER JOIN
    Player ON TeamComposition.PlayerID = Player.PlayerID
GROUP BY
    Team.TeamID, Team.TeamSportName;

SELECT * FROM Player WHERE PlayerFName LIKE 'Emily';

SELECT A.StudentID AS Student1ID, A.StudentMajor AS Student1Major, A.StudentGPA AS Student1GPA, A.StudentAdvisor AS Student1Advisor,
       B.StudentID AS Student2ID, B.StudentMajor AS Student2Major, B.StudentGPA AS Student2GPA, B.StudentAdvisor AS Student2Advisor
FROM STUDENT A
INNER JOIN STUDENT B ON A.StudentID <> B.StudentID AND A.StudentMajor = B.StudentMajor;

SELECT NatID, TournamentName, TournamentLocation
FROM NATIONALTOURNAMENT
INNER JOIN Tournament ON NATIONALTOURNAMENT.TourID = Tournament.TournamentID;


SELECT ScholarshipID, ScholarshipAmount, ScholarshipStartDate, ScholarshipEndDate, ScholarshipType, ScholarshipStatus,
       PlayerID
FROM Scholarship 
WHERE ScholarshipStatus = 'Pending';





















