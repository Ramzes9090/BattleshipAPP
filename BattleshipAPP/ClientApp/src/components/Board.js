import React, { useState } from 'react';

const Board = () => {
    const [board, setBoard] = useState(Array(10).fill(Array(10).fill('white')));

    const changeColor = (rowIndex, colIndex) => {
        // Create a copy of the board with the clicked tile's color changed
        const newBoard = board.map((row, i) =>
            row.map((color, j) => (i === rowIndex && j === colIndex ? 'blue' : color))
        );

        setBoard(newBoard);
    };

    return (
        <div>
        
        <div className="color-board">
            {board.map((row, rowIndex) => (
                <div className="row" key={rowIndex}>
                    {row.map((color, colIndex) => (
                        <div
                            className="tile"
                            key={colIndex}
                            style={{ backgroundColor: color }}
                            
                        ></div>
                    ))}
                </div>
            ))}
            </div>
            <div className="btn" style={{ width: "70px", height: "70px", backgroundColor: "red" }} onClick={() => changeColor(2, 5)}></div>
        </div>
    );
};

export default Board;