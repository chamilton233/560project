IF OBJECT_ID(N'BasketBall.BasketballTeam') IS NULL
BEGIN
create table BasketBall.BasketballTeam
(
    TeamId int not null IDENTITY(1,1) PRIMARY Key,
    Name NVARCHAR(128) not null,
    ConferenceId int not null FOREIGN key REFERENCES BasketBall.Conference(ConferenceId),
    UNIQUE
    (
        Name
    )
)
END;