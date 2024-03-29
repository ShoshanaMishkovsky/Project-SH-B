CREATE TABLE [dbo].[WorkHours] (
[code]       INT            IDENTITY (1, 1) NOT NULL ,
    [dayInTheWeek] INT      NOT NULL,
    [dieticanId]   INT      NOT NULL,
    [startHour]    TIME (7) NOT NULL,
    [endHour]      TIME (7) NOT NULL,
    CONSTRAINT [dieticanId_fk2] FOREIGN KEY ([dieticanId]) REFERENCES [dbo].[Dietitians] ([id]),
    CONSTRAINT [check_dayInTheWeek] CHECK ([dayInTheWeek]>=(1) AND [dayInTheWeek]<=(5))
);