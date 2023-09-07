import React, { useState,useEffect} from 'react'
import Square from './Square'

// Represents a 10 x 10 grid of grid squares

export default function Board({shipOne,shipTwo,shipThree,shipFour}) {

    // generates an array of 10 rows, each containing 10 GridSquares.

    const grid = [];
    for (let row = 0; row < 10; row++) {
        grid.push([])
        for (let col = 0; col < 10; col++) {
            grid[row].push(<Square key={`${col}${row}`} color="1" />)
        }
    }
    function ChangeColor(a, b) {
        for (let row = 0; row < 10; row++) {
            
            for (let col = 0; col < 10; col++) {
                if (col === a && row === b) {
                    grid[row].splice(a, 1, <Square key={`${col}${row}`} color="2" />)
                }
            }
        }
    }
    function PlaceShip(strCol, strRow, long, horizontal) {
        var index = 0;
        if (horizontal) {
            while (index < long) {
                ChangeColor(strCol + index, strRow);
                index++;
            }
        }
        else if (!horizontal) {
            while (index < long) {
                ChangeColor(strCol, strRow+index);
                index++;
            }
        }
    }

    PlaceShip(shipOne.strCol, shipOne.strRow, shipOne.length, shipOne.horizontal);
    PlaceShip(shipTwo.strCol, shipTwo.strRow, shipTwo.length, shipTwo.horizontal);
    PlaceShip(shipThree.strCol, shipThree.strRow, shipThree.length, shipThree.horizontal);
    PlaceShip(shipFour.strCol, shipFour.strRow, shipFour.length, shipFour.horizontal);

    const tab = [];
    const x = 1;
    const y = 2;

    function shooting(x,y) {
        for (let row = 0; row < 10; row++) {

            for (let col = 0; col < 10; col++) {
                if (col === x && row === y) {
                    grid[row].splice(x, 1, <Square key={`${col}${row}`} color="3" />)
                }
            }
        }
    }
    shooting(x, y);
    // The components generated in makeGrid are rendered in div.grid-board

    return (
        <div className='grid-board'>
            {grid}
        </div>
    )
}






