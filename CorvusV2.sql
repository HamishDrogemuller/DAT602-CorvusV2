-- Drop Database to allow clean start
Drop Database if exists Corvus;
Create Database Corvus;
Use Corvus;

-- Drop Procedure
Drop Procedure if exists MakeCorvus;
Delimiter //
-- Creating a Create Database Procedure
Create Procedure MakeCorvus()
Begin
-- Dropping all tables in case they are already present
Drop Table if Exists tblAccount;
Drop Table if Exists tblTile;
Drop Table if Exists tblPlayerLocation;
Drop Table if Exists tblChat;

Drop User If Exists 'Strix'@'localhost';

Create User 'Strix'@'localhost' Identified By 'Corvere300';
Grant All On Corvus.* To 'Strix'@'localhost';
 
-- Creation of account table to store user details
Create Table tblAccount(
		email Varchar(50) Not Null Primary Key,
        username Varchar(20) Unique Not Null,
        `password` Varchar(50),
        lockedUser Bool Default 0,
        `admin` Bool Default 0,
        loginAttempt Smallint Default 0,
        `online` Bool Default 0,
        score Integer(10) Default 0,
        highScore Integer(10) Default 0
);

-- Creation of Tile table to store table details
Create Table tblTile(
	tileID Integer Auto_Increment Primary Key,
    `row` Integer(10) Not Null,
    `column` Integer(10) Not Null,
    crow Bool Not Null Default 0,
    `trap` Bool Not Null Default 0,
    homeTile Bool Not Null Default 0
);

-- Creation of table to store player location
Create Table tblPlayerLocation(
	username Varchar(20) Unique Not Null,
    tileID Integer(10) Not Null,
    Primary Key (username,tileID),
    Foreign Key (username) References tblAccount(username),
    Foreign Key (tileID) References tblTile(tileID)
);

-- Creation of chat table
   Create Table tblChat
   (
		chatID Integer(10) Auto_Increment Primary Key,
		username Varchar(20),
        message Varchar(255),
        Foreign Key (username) References tblAccount(username)
   );

End //
Delimiter ;

Drop Procedure If Exists PopulateCorvus;
Delimiter //

Create Procedure PopulateCorvus()
Begin 
    Insert Into tblAccount(email,username,`password`,`admin`)
    Values
		('strixhc@gmail.com','Strix','Corvere300', True),
		('than@tos.com','Thanatos','HadesSucks', False),
		('zag@gmail.com','Zagreus','HadesSucks2', False),
		('hades@gmail.com','Hades','HadesRules321', False),
		('nyx@styx.com','Nyx','worldsBestMum', True),
		('goodboy@styx.com','Cerberus','goodboy', False),
		('queen@olympus.com','Hera','ZeusSucks', False),
		('king@olympus.com','Zeus','lookingforfun123', False),
		('hypnos@zzz.com','Hypnos','likes2Sleep', False),
		('achilles@protonmail.com','Achilles','Patroclus<3',False),
        ('TestCase@gmail.com','TestCase','Testing',False);
        
	Insert Into tblTile(tileID, `row`, `column`)
    Values
		(1,1,1),
		(2,2,2),
		(3,3,3),
		(4,4,4),
		(5,5,5),
		(6,6,6),
		(7,7,7),
		(8,8,8),
		(9,9,9),
		(10,10,10),
		(11,0,11),
		(12,0,12),
		(13,0,13),
		(14,0,14),
		(15,0,15),
		(16,0,16),
		(17,0,17),
		(18,0,18),
		(19,0,19),
		(20,0,20);
        
	Insert Into tblPlayerLocation(username,tileID)
    Values
		('Strix',1),
        ('Thanatos',2),
        ('Nyx',3);
        
	Insert Into tblChat(username,message)
    Values
		('Strix','Test Message'),
        ('Thanatos','Test Reply');

End //
Delimiter ;
Call MakeCorvus();

Call PopulateCorvus();

Drop Procedure if Exists TestData;
Delimiter //

Create Procedure TestData()
Begin

-- tblAccount Test Data
	-- Select
	Select username, email
    From tblAccount
    Where username = 'Strix';
    
    -- Update
    Update tblAccount
    Set email = 'HCStrix@gmail.com'
    Where username = 'Strix';
    
    -- Delete
    Delete 
    From tblAccount
    Where username = 'TestCase';
    
    -- Select
    Select *
    From tblAccount;
    
-- tblTile Test Data
    -- Select
    Select tileID, `row`, `column`
    From tblTile;
    
    -- Update
    Update tblTile
    Set tileID = '21'
    Where tileID = '20';
    
    -- Delete
    Delete
    From tblTile
    Where tileID = '21';
    
    -- Select
        Select *
		From tblTile;
        
-- tblPlayerLocation Test Data
    -- Select
    Select username, tileID
    From tblPlayerLocation
    Where username = 'Strix';
    
    -- Update 
    Update tblPlayerLocation
    Set tileID = 10
    Where username = 'Strix';
    
    -- Delete
    Delete
    From tblPlayerlocation
    Where username = 'Nyx';
    
    -- Select
    Select *
    From tblPlayerLocation;
    
-- tblChat Test Data
    -- Select
    Select username, message
    From tblChat
    Where username = 'Thanatos';
    
    -- Update
    Update tblChat
    Set message = "This a great update"
    Where username = 'Thanatos';
    
    -- Delete
    Delete
    From tblChat
    Where username = 'Strix';
    
    -- Select
    Select *
    From tblChat;
    
End //
Delimiter ;

Call TestData();

-- >>>>>>>>>>>>>>
-- Procedure List
-- >>>>>>>>>>>>>>
/*
Account
	Login - Complete
	Logout - Complete
	register - Complete
	deleteAccount - Complete
getActivePlayers - Complete
getAllUsers - Complete
generateGameSpace - Complete
		SetHome - Complete
	setTraps - Complete
    setCrows - Complete
joinGame - Complete
playerMove - Complete
    checkDestinationTile - Complete
	trapEffect - Complete
    crowEffect - Complete
    addScore - Complete
chat - Complete
gameEnd - Complete
admin - Complete
	updatePlayer - Complete
    deletePlayer - Complete
*/

-- Login Procedure
Drop Procedure If Exists Login;
Delimiter //
Create Procedure Login(IN pUsername Varchar(20), IN pPassword Varchar(50))
Begin
    Declare loginAttempt INT DEFAULT 0;
    
	-- 'Check for valid login', 
    -- if valid then select message "Logged in" and reset Attempts to 0, 
    If Exists( Select * 
                From tblAccount
                Where 
                  username = pUsername AND
                  `password` = pPassword 
                  ) 
	Then
		Update tblAccount 
        SET loginAttempt = 0, `online` = True
        WHERE
           username = pUsername;
           
		Select 'Logged In' As Message;
    
    Else
    -- else add to Attempts ,
        If Exists(Select * From tblAccount Where username = pUsername) Then 
        
			Select loginAttempt
			From tblAccount
			Where 
			   username = pUsername;
			
			Set loginAttempt = loginAttempt + 1;
			
			If loginAttempt > 5 Then 
			-- if Attempts > 5 then set lockout  to true and select message 'locked out' 
				Update tblAccount 
				Set lockedUser = True
				Where 
					 username = pUsername ;
					 
				 Select 'Locked Out' As Message;
				 
			Else
			-- else select message 'Bad  password'
                 Update tblAccount
                 Set loginAttempt = loginAttempt
                 Where 
                    username = pUsername;
                    
				 Select 'Invalid user name and password' As Message;
			End If;
      Else 
		Select 'Invalid user name and password' As Message;
      End If;

    
    End If;


End //
Delimiter ;

-- Adding a new user procedure
Drop Procedure if exists AddNewUser;
Delimiter //

Create Procedure AddNewUser(pUsername Varchar(20), pPassword Varchar(50), pEmail Varchar(50))
Begin
  If Exists (Select * 
     From tblAccount
     Where username = pUsername) 
     Then
		Begin
			Select 'User Exists' As Message;
		End;
	Else
		Insert Into tblAccount(username,`password`,email)
        Values
			(pUsername,pPassword,pEmail);
            Select 'Welcome to Corvus' As Message;
		End If;
        
        End //
Delimiter ;

-- Logout Procedure
Drop Procedure If Exists Logout;
Delimiter //

Create Procedure Logout(IN pUsername Varchar(20))
Begin
	If Exists(Select *
				From tblAccount
				Where username = pUsername)
			Then
				Update tblAccount
                Set `online` = False
                Where username = pUsername;
                
                Select Concat(pUsername, ' Logged Out') As Message;
			End If;
End //
Delimiter ;

-- Delete Account
Drop Procedure If Exists deleteAccount;
Delimiter //

Create Procedure deleteAccount(In pUsername Varchar(20))
Begin
	If (Select username
		From tblAccount
        Where username = pUsername) = pUsername
	Then
		Delete From tblAccount
        Where username = pUsername;
        
        Select Concat('Account ',pUsername,' Deleted') As Message;
	Else
		Select Concat(pUsername,' Does Not Exist') As Message;
	End If;

End //
Delimiter ;

-- Get Active Players
Drop Procedure If Exists getActivePlayers;
Delimiter //

Create Procedure getActivePlayers()
Begin
	Select username, email, `online`
    From tblAccount
    Where `online` = True AND `admin` = False;

End //
Delimiter ;

-- Get All Users
Drop Procedure If Exists getAllUsers;
Delimiter //

Create Procedure getAllUsers()
Begin
	Select *
    From tblAccount
    Order By username Asc;
End //
Delimiter ;

-- Create Board Generation
Drop Procedure If Exists generateBoard;
Delimiter //

Create Procedure generateBoard()
Begin
	-- Declare Variables
	-- Tiles
    Declare pRow Int;
    Declare pColumn Int;
    Declare maxRow Int;
    Declare maxColumn Int;
    -- Traps
    Declare pTileMax Int;
    Declare trapCount Int;
    Declare loopCounter Int;
    Declare randomTile Int;
    -- Crows
    Declare isTrap Int;
    Declare crowCount Int;
    
    -- Generating Tiles
    Set pRow = 0;
    Set maxRow = 11;
    While pRow < maxRow Do
		Set pColumn = 0;
        Set maxColumn = 21;
        While pColumn < maxColumn Do
			Insert Into tblTile(`row`,`column`)
			Value (pRow, pColumn);
            Set pColumn = pColumn + 1;
		End While ;
        Set pRow = pRow + 1;
	End While;
    
   -- HomeTile
   Update tblTile
   Set homeTile = True
   Where tileID = 103;
   
   -- Traps
   Set pTileMax = 200;
   Set trapCount = 70;
   Set loopCounter = 0;
   
   trap: While loopCounter < trapCount Do
			Set randomTile = Floor((Rand() * pTileMax) + 1);
			If randomTile = 103
			Then Iterate trap;
			End If;
			Update tblTile
			Set `trap` = True
			Where tileID = randomTile;
			Set loopCounter = loopCounter + 1;
		End While;
    
    -- Release Crows
    Set pTileMax = 200;
    Set crowCount = 100;
    Set loopCounter = 0;
    
    crows: While loopcounter < crowCount Do
				Set isTrap = 0;
                Set randomTile = Floor(Rand() * pTileMax) + 1;
                Set isTrap = (Select `trap`
								From tblTile
                                Where tileID = randomTile);
				If randomTile = 103 or isTrap = True
                Then Iterate crows;
                End If;
                Update tblTile
                set crow = crow = True
                Where tileID = randomTile;
                Set loopCounter = loopCounter + 1;
			End While;
		Select 'Happy Hunting' As Message;
    
End //
Delimiter ;

-- Join Game
Drop Procedure If Exists joinGame;
Delimiter //

Create Procedure joinGame(
In pUsername Varchar(50))
Begin
	Select username Into @username
    From tblAccount
    Where username = pUsername;
    Insert Into tblPlayerLocation (username, tileID)
    Values (pUsername, 103);
    
    Select Concat('Welcome to Corvus ', pUsername) As Message;
End //
Delimiter ;

-- Update High Score
Drop Procedure If Exists updateHighscore;
Delimiter //

Create Procedure updateHighscore(In pUsername Varchar(20))
Begin
	Update tblAccount
    Set highScore = score
    Where username = pUsername AND score > highScore;
    If (row_count() > 0) Then
		Select 'New High Score!' As Message;
	Else
		Select 'Better luck next time' As Message;
	End If;
End //
Delimiter ;

-- Movement
Drop Procedure If Exists playerMove;
Delimiter //

Create Procedure playerMove(In pUsername Varchar(20), In pTileID Int)
Begin
	-- Declare Variables
	Declare currentTileRow Int;
    Declare currentTileColumn Int;
    Declare newTileRow Int;
    Declare newTileColumn Int;
    
    Select `row`
    From tblTile
    Join tblPlayerLocation On tblTile.tileID = tblPlayerLocation.tileID
    Where username = pUsername
    Into currentTileRow;
    
    Select `column`
    From tblTile
    Join tblPlayerLocation On tblTile.tileID = tblPlayerLocation.tileID
    Where username = pUsername
    Into currentTileColumn;
    
    Select `row`
    From tblTile
    Where tileID = pTileID
    Into newTileRow;
    
    Select `column`
    From tblTile
    Where tileID = pTileID
    Into newTileColumn;
    
    If ((newTileRow = currentTileRow Or newTileRow = currentTileRow + 1 Or newTileRow = currentTileRow - 1)
		And (newTileColumn = currentTileColumn Or newTileColumn = currentTileColumn + 1 Or newTileColumn = currentTileColumn - 1))
        
	Then
		Select tileID, trap, crow
        Into @tileID, @trap, @crow
        From tblTile
        Where tileID = pTileID;
        
        If @crow <> 0 Then
			Update tblPlayerLocation
            Set tileID = pTileID
            Where username = pUsername;
            
            Update tblAccount
            Set score = score + @crow
            Where username = pUsername;
            
            Update tblTile
            Set crow = False
            Where tileID = pTileID;
            
            Select 'Move complete, Crows have been caught' As Message;
            Call updateHighscore(pUsername);
            
		ElseIf @trap = false and @crow = false 
			Then
				Update tblPlayerLocation
                Set tileID = pTileID
                Where username = pUsername;
                
                Select 'Move completed' As Message;
                
		ElseIf @trap = True	
			Then
				Update tblAccount
                Set score = score - 3
                Where username = pUsername;
                
                Select 'Trapped! Youve dropped some crows!' As Message;
		
        End If;
	Else
		Select 'Cannot move here' As Message;
	End If;
End //
Delimiter ;

-- Chat function procedure
Drop Procedure If Exists chatMessage;
Delimiter //

Create Procedure chatMessage(In pMessage Varchar(255), In pUsername Varchar(20))
Begin
	Insert Into tblChat (message, username)
    Value(pMessage, pUsername);
    
    Select * From tblChat;
End //
Delimiter ;

-- Game End

Drop Procedure If Exists gameEnd;
Delimiter //

Create Procedure gameEnd()
Begin
	Declare minScore Int;
    Set minScore = (Select min(score) From tblAccount);
    
		If minScore > 0
			Then
			Select username, score Into @username, @score
			From tblAccount
			Where score = (
				Select Max(score)
				From tblAccount);
        
		Select Concat(@username, 'Wins the hunt with ', @score, 'crows!') As Message;
    
		Update tblAccount
		Set score = 0;
    
		Update tblPlayerLocation
		Set tileID = 103;
	Else 
			Select 'No players have distinguished themselves' As Message;
	End If;
        
End //
Delimiter ;

-- adminUpdateUser
Drop Procedure If Exists adminUpdateUser;
Delimiter //

Create Procedure adminUpdateUser( In pUsername Varchar(20), In pEmail Varchar(50), In pPassword Varchar(50))
Begin
	If Exists (Select email
				From tblAccount
                Where email = pEmail)
	Then
				Update tblAccount
                Set username = pUsername, `password` = pPassword
                Where tblAccount.email = pEmail;
	End If;
		Select Concat(pUsername, ' Has been updated') As Message;
End //
Delimiter ;

Drop Procedure If Exists unlockPlayer;
Delimiter //

Create Procedure unlockPlayer(pUsername Varchar(20))
Begin
	If Exists(
		Select username
		From tblAccount
		Where username = pUsername)
        
	Then
		Update tblAccount
        Set lockedUser = 0
        Where tblAccount.Username = pUsername;
	
    End If;
		Select Concat(pUsername, ' Account has been Unlocked') As Message;

End //
Delimiter ;


 -- Calls
-- Calling Login
Call Login('Zeus', 'lookingforfun123');
Call Login('Thanatos','HadesSucks');
Call Login('Strix','Corvere300');
Call Login('Hera','ZeusSucks');
/*
-- Add New User
Call AddNewUser('Sisyphus','Boulderpusher#1','Sisyphus@rockroll.com');
-- Logout
Call Logout('Zeus');
-- Call deleteAccount
Call deleteAccount('Zeus');
-- Call getActivePlayers
Call getActivePlayers();
-- Call getAllUsers
Call getAllUsers();
-- Call Generate Board
Call generateBoard();
-- Call join Game
Call joinGame('Sisyphus');
-- Call joinGame('Strix');
-- Call updateHighscore
Call updateHighscore('Strix');
-- Call playerMove
Call playerMove('Strix',9);
Call playerMove('Sisyphus',102);
-- Call chatMessage
Call chatMessage('Hello', 'Strix');
-- Call gameEnd
Call gameEnd();
-- Call AdminUpdateUser
Call adminUpdateUser('Strix','HCStrix@protonmail.com','Corvere300')
-- Call unlockPlayer
Call unlockPlayer('Strix');
*/