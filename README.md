# Knight-Tour
I began with a blank chess board and placed the knight at the lower left corner of the board. Then, I checked for possible valid moves from that initial point. From a point on chessboard , there are maximum of 8 possible moves. But if the knight's position is towards the edge of the board, then the possible moves will be literally out of the chessboard. Hence a function to check the valid moves of the knight has been implemented. If the move is valid, then the knight is placed to that block. Valid move also check if the block is free, not out of board and not already covered by the knight.

Each movement is displayed in the program.

The code is for a 8X8 chess board (usually chessboards are 8X8 !!). If the board dimension needs to be changed, then a comand to prompt user to ener the dimension can be added. if MXN dimension needs to be implemented then another variable to be added to hold the M value .
