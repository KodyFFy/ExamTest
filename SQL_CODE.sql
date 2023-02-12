DECLARE @cursor_ CURSOR 

DECLARE @name_ CHAR(50)
DECLARE @category CHAR(50)

SET @cursor_ = CURSOR FOR SELECT name_, category_ FROM table_

OPEN @cursor_
FETCH NEXT FROM @cursor_ INTO @name, @category

WHILE @@FETCH_STATUS = 0

BEGIN
	
	IF @category = Null
		PRINT @name
	ELSE
		PRINT @name + '-' @category
	
	FETCH NEXT FROM @cursor_ INTO @name, @category

END

CLOSE @cursor_
DEALLOCATE  @cursor_
