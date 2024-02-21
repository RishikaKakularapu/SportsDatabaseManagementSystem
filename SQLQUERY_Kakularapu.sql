CREATE DATABASE SportsDatabaseManagementSystem;
GO

USE SportsDatabaseManagementSystem;
GO

-- Create PLAYER table
CREATE TABLE PLAYER (
    PlayerID INT PRIMARY KEY NOT NULL,
    PlayerFName VARCHAR(255),
    PlayerLName VARCHAR(255),
    PlayerDOB DATE,
    PlayerGen VARCHAR(10),
    PlayerHt FLOAT,
    PlayerWt FLOAT,
    PlayerPhone VARCHAR(20),
    PlayerEmail VARCHAR(255)
);


-- Create STUDENT table
CREATE TABLE STUDENT (
    StudentID INT PRIMARY KEY,
    PlayerID INT FOREIGN KEY REFERENCES PLAYER(PlayerID),
    StudentMajor VARCHAR(255),
    StudentGPA FLOAT,
    StudentClub VARCHAR(255),
    StudentAdvisor VARCHAR(255),
    StudentUniformNum INT
);


-- Create ATHLETE table
CREATE TABLE ATHLETE (
    AthleteID INT PRIMARY KEY,
    PlayerID INT FOREIGN KEY REFERENCES PLAYER(PlayerID),
    AthleteSalary VARCHAR(255),
    AthletePosition VARCHAR(255),
    AthleteAgent VARCHAR(255),
    AthleteUniformNum INT
);


-- Create COACH table
CREATE TABLE COACH (
    CoachID INT PRIMARY KEY,
    CoachFName VARCHAR(255),
    CoachLName VARCHAR(255),
    PlayerID INT FOREIGN KEY REFERENCES PLAYER(PlayerID),
    CoachExp INT,
    CoachPhone VARCHAR(20),
    CoachEmail VARCHAR(255)
);


-- Create SCHOLARSHIP table
CREATE TABLE SCHOLARSHIP (
    ScholarshipID INT PRIMARY KEY,
    PlayerID INT FOREIGN KEY REFERENCES PLAYER(PlayerID),
    ScholarshipAmount FLOAT,
    ScholarshipStartDate DATE,
    ScholarshipEndDate DATE,
    ScholarshipType VARCHAR(255),
    ScholarshipStatus VARCHAR(20)
);


-- Create TOURNAMENT table
CREATE TABLE TOURNAMENT (
    TournamentID INT PRIMARY KEY,
    TournamentName VARCHAR(255),
    TournamentStartDate DATE,
    TournamentLocation VARCHAR(255),
    TournamentSportName VARCHAR(255),
    TournamentType VARCHAR(255)
);


-- Create MATCH table
CREATE TABLE MATCH (
    MatchID INT PRIMARY KEY,
    MatchDate DATE,
    MatchOutcome VARCHAR(255),
    MatchDuration FLOAT
);


-- Create LEAGUE table
CREATE TABLE LEAGUE (
    LeagueID INT PRIMARY KEY,
    TournamentID INT FOREIGN KEY REFERENCES TOURNAMENT(TournamentID),
    PlayerID INT FOREIGN KEY REFERENCES PLAYER(PlayerID),
    LeagueName VARCHAR(255),
    LeagueStartDate DATE,
    LeagueEndDate DATE,
    LeagueSport VARCHAR(255)
);


-- Create GAME table
CREATE TABLE GAME (
    GameID INT PRIMARY KEY,
    MatchID INT FOREIGN KEY REFERENCES MATCH(MatchID),
    GameScore INT,
    GameDate DATE
);


-- Create TEAM table
CREATE TABLE TEAM (
    TeamID INT PRIMARY KEY,
    GameID INT FOREIGN KEY REFERENCES GAME(GameID),
    TeamSportName VARCHAR(255),
    TeamLen INT,
);


-- Create REGIONAL table
CREATE TABLE REGIONAL (
    RegID INT PRIMARY KEY,
    TourID INT FOREIGN KEY REFERENCES TOURNAMENT(TournamentID),
    RegLocation VARCHAR(255)
);


-- Create NATIONALTOURNAMENT table
CREATE TABLE NATIONALTOURNAMENT (
    NatID INT PRIMARY KEY,
    TourID INT FOREIGN KEY REFERENCES TOURNAMENT(TournamentID),
    NatState VARCHAR(255)
);


-- Create INTERNATIONAL table
CREATE TABLE INTERNATIONAL (
    InterID INT PRIMARY KEY,
    TourID INT FOREIGN KEY REFERENCES TOURNAMENT(TournamentID),
    InterCountry VARCHAR(255)
);


-- Create TEAMCOMPOSITION table
CREATE TABLE TEAMCOMPOSITION (
    TeamID INT,
    PlayerID INT,
    PlayerPosition VARCHAR(255),
    PRIMARY KEY (TeamID, PlayerID),
    FOREIGN KEY (TeamID) REFERENCES Team(TeamID),
    FOREIGN KEY (PlayerID) REFERENCES Player(PlayerID)
);

-- Insert Records into PLAYER Table
INSERT INTO PLAYER (PlayerID, PlayerFName, PlayerLName, PlayerDOB, PlayerGen, PlayerHt, PlayerWt, PlayerPhone, PlayerEmail)
VALUES
(1, 'John', 'Doe', '1990-05-15', 'Male', 180.5, 75.2, '123-456-7890', 'john.doe@email.com'),
(2, 'Jane', 'Smith', '1992-08-20', 'Female', 165.2, 60.8, '987-654-3210', 'jane.smith@email.com'),
(3, 'Mike', 'Johnson', '1988-12-10', 'Male', 175.0, 70.5, '555-123-4567', 'mike.johnson@email.com'),
(4, 'Emily', 'Brown', '1995-03-25', 'Female', 160.0, 55.3, '111-222-3333', 'emily.brown@email.com'),
(5, 'Chris', 'Anderson', '1985-06-05', 'Male', 185.5, 80.0, '999-888-7777', 'chris.anderson@email.com'),
(6, 'Samantha', 'Williams', '1993-09-12', 'Female', 170.0, 62.5, '111-222-3333', 'samantha@email.com'),
(7, 'Michael', 'Brown', '1991-04-18', 'Male', 182.5, 78.0, '444-555-6666', 'michael@email.com'),
(8, 'Lauren', 'Clark', '1994-11-25', 'Female', 160.5, 55.8, '777-888-9999', 'lauren@email.com'),
(9, 'Daniel', 'Smith', '1990-07-05', 'Male', 175.0, 68.2, '999-888-7777', 'daniel@email.com'),
(10, 'Emily', 'Johnson', '1992-02-28', 'Female', 168.0, 61.0, '333-444-5555', 'emily@email.com'),
(11, 'Michael', 'Jordan', '1963-02-17', 'Male', 198, 98, '1234567891', 'michael.jordan@example.com'),
(12, 'LeBron', 'James', '1984-12-30', 'Male', 206, 113, '1234567892', 'lebron.james@example.com'),
(13, 'Serena', 'Williams', '1981-09-26', 'Female', 175, 70, '1234567893', 'serena.williams@example.com'),
(14, 'Lionel', 'Messi', '1987-06-24', 'Male', 170, 72, '1234567894', 'lionel.messi@example.com'),
(15, 'Simone', 'Biles', '1997-03-14', 'Female', 142, 47, '1234567895', 'simone.biles@example.com');

-- Insert Records into STUDENT Table
INSERT INTO STUDENT (StudentID, PlayerID, StudentMajor, StudentGPA, StudentClub, StudentAdvisor, StudentUniformNum)
VALUES
(101, 1, 'Computer Science', 3.5, 'Football Club', 'Dr. Smith', 123),
(102, 2, 'Business Administration', 3.2, 'Basketball Club', 'Prof. Johnson', 456),
(103, 6, 'Computer Science', 3.8, 'Tennis Club', 'Dr. White', 789),
(104, 4, 'Psychology', 3.6, 'Swimming Club', 'Prof. Davis', 234),
(105, 8, 'Physics', 3.9, 'Golf Club', 'Dr. Taylor', 567);

-- Insert Records into ATHLETE Table
INSERT INTO ATHLETE (AthleteID, PlayerID, AthleteSalary, AthletePosition, AthleteAgent, AthleteUniformNum)
VALUES
(201, 7, '$1,000,000', 'Forward', 'Sports Agency A', 11),
(202, 3, '$800,000', 'Goalkeeper', 'Sports Agency B', 22),
(203, 5, '$1,500,000', 'Midfielder', 'Sports Agency C', 33),
(204, 9, '$700,000', 'Defender', 'Sports Agency A', 44),
(205, 10, '$1,200,000', 'Forward', 'Sports Agency B', 55);

-- Insert Records into COACH Table
INSERT INTO Coach (CoachID, CoachFName, CoachLName, PlayerID, CoachExp, CoachPhone, CoachEmail)
VALUES
(301, 'Tom', 'Williams', 1, 8, '777-888-9999', 'tom.williams@email.com'),
(302, 'Lisa', 'Miller', 3, 10, '444-555-6666', 'lisa.miller@email.com'),
(303, 'Robert', 'Clark', 5, 12, '222-333-4444', 'robert.clark@email.com'),
(304, 'Sarah', 'Smith', 2, 7, '888-999-0000', 'sarah.smith@email.com'),
(305, 'David', 'Lee', 4, 9, '666-777-8888', 'david.lee@email.com');

-- Insert Records into SCHOLARSHIP Table
INSERT INTO SCHOLARSHIP (ScholarshipID, PlayerID, ScholarshipAmount, ScholarshipStartDate, ScholarshipEndDate, ScholarshipType, ScholarshipStatus)
VALUES
(501, 1, 5000.00, '2022-01-01', '2022-12-31', 'Sports Merit Scholarship', 'Approved'),
(502, 2, 4500.00, '2022-02-01', '2022-11-30', 'Full Athletic Scholarship', 'Pending'),
(503, 3, 6000.00, '2022-03-01', '2022-10-31', 'Sports Excellence', 'Approved'),
(504, 4, 4000.00, '2022-04-01', '2022-09-30', 'Athletic Achievement', 'Pending'),
(505, 5, 5500.00, '2022-05-01', '2022-08-31', 'Sports Excellence', 'Approved');

-- Insert Records into TOURNAMENT Table
INSERT INTO TOURNAMENT (TournamentID, TournamentName, TournamentStartDate, TournamentLocation, TournamentSportName, TournamentType)
VALUES
(601, 'Summer Cup', '2022-07-01', 'City Stadium', 'Football', 'League'),
(602, 'Basketball Championship', '2022-08-15', 'Arena A', 'Basketball', 'Playoff'),
(603, 'Tennis Open', '2022-06-10', 'Tennis Club', 'Tennis', 'Knockout'),
(604, 'Golf Masters', '2022-09-05', 'Golf Course', 'Golf', 'Invitational'),
(605, 'Swimming Nationals', '2022-07-20', 'Aquatic Center', 'Swimming', 'Championship'),
(611, 'National Soccer Cup', '2023-05-01', 'National Stadium', 'Soccer', 'National'),
(612, 'National Basketball Championship', '2023-05-05', 'Basketball Arena', 'Basketball', 'National'),
(613, 'National Tennis Open', '2023-05-10', 'Tennis Club', 'Tennis', 'National'),
(614, 'National Golf Masters', '2023-05-15', 'Golf Course', 'Golf', 'National'),
(615, 'National Swimming Nationals', '2023-05-20', 'Aquatic Center', 'Swimming', 'National'),
(621, 'International Soccer World Cup', '2023-06-01', 'International Stadium', 'Soccer', 'International'),
(622, 'International Basketball Cup', '2023-06-05', 'International Arena', 'Basketball', 'International'),
(623, 'International Tennis Masters', '2023-06-10', 'Global Tennis Club', 'Tennis', 'International'),
(624, 'International Golf Open', '2023-06-15', 'Global Golf Course', 'Golf', 'International'),
(625, 'International Swimming Championships', '2023-06-20', 'Global Aquatic Center', 'Swimming', 'International');

-- Insert Records into MATCH Table
INSERT INTO MATCH (MatchID, MatchDate, MatchOutcome, MatchDuration)
VALUES
(701, '2022-07-05', 'Win', 2.5),
(702, '2022-08-18', 'Loss', 3.0),
(703, '2022-06-15', 'Draw', 2.2),
(704, '2022-09-08', 'Win', 2.8),
(705, '2022-07-25', 'Loss', 3.5);

-- Insert Records into LEAGUE Table
INSERT INTO LEAGUE (LeagueID, TournamentID, PlayerID, LeagueName, LeagueStartDate, LeagueEndDate, LeagueSport)
VALUES
(801, 601, 1, 'Football Premier League', '2022-07-01', '2022-08-31', 'Football'),
(802, 602, 2, 'Basketball Pro League', '2022-08-15', '2022-09-30', 'Basketball'),
(803, 603, 3, 'Tennis Grand Slam', '2022-06-10', '2022-06-30', 'Tennis'),
(804, 604, 4, 'Golf Masters Invitational', '2022-09-05', '2022-09-10', 'Golf'),
(805, 605, 5, 'Swimming Nationals Championship', '2022-07-20', '2022-07-25', 'Swimming');

-- Insert Records into GAME Table
INSERT INTO GAME (GameID, MatchID, GameScore, GameDate)
VALUES
(901, 701, 3, '2022-07-05'),
(902, 702, 85, '2022-08-18'),
(903, 703, 1, '2022-06-15'),
(904, 704, 2, '2022-09-08'),
(905, 705, 0, '2022-07-25');

-- Insert Records into REGIONAL Table
INSERT INTO REGIONAL (RegID, TourID, RegLocation)
VALUES
(1001, 601, 'City Stadium'),
(1002, 602, 'Arena A'),
(1003, 603, 'Tennis Club'),
(1004, 604, 'Golf Course'),
(1005, 605, 'Aquatic Center');

-- Insert Records into NATIONALTOURNAMENT Table
INSERT INTO NATIONALTOURNAMENT(NatID, TourID, NatState)
VALUES
(1101, 611, 'United States'),
(1102, 612, 'United States'),
(1103, 613, 'United States'),
(1104, 614, 'United States'),
(1105, 615, 'United States');

-- Insert Records into INTERNATIONAL Table
INSERT INTO INTERNATIONAL (InterID, TourID, InterCountry)
VALUES
(1201, 621, 'England'),
(1202, 622, 'Spain'),
(1203, 623, 'France'),
(1204, 624, 'Scotland'),
(1205, 625, 'Australia');


-- Insert Records into TEAM Table
INSERT INTO TEAM (TeamID, GameID, TeamSportName, TeamLen)
VALUES
(1301, 901, 'Football Team A', 11),
(1302, 902, 'Basketball Team B', 8),
(1303, 903, 'Tennis Doubles', 2),
(1304, 904, 'Golf Team', 1),
(1305, 905, 'Swimming Relay', 4);

-- Insert Records into TEAMCOMPOSITION Table
INSERT INTO TEAMCOMPOSITION (TeamID, PlayerID, PlayerPosition)
VALUES
-- Team 1301
(1301, 1, 'Forward'),
(1301, 2, 'Midfielder'),
(1301, 3, 'Defender'),
(1301, 4, 'Goalkeeper'),
(1301, 5, 'Midfielder'),

-- Team 1302
(1302, 6, 'Guard'),
(1302, 7, 'Forward'),
(1302, 8, 'Center'),
(1302, 9, 'Guard'),
(1302, 10, 'Center'),

-- Team 1303
(1303, 11, 'Player 1'),
(1303, 12, 'Player 2'),
(1303, 13, 'Player 3'),
(1303, 14, 'Player 4'),
(1303, 15, 'Player 5');

























