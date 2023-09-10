import React, { useState, useEffect } from 'react'
import GamePage from './GamePage'

// Represents a 10 x 10 grid of grid squares

export default function MainPage() {
    const [shot, setShot] = useState([]);
    var [playerOne, setPlayerOne] = useState([]);
    var [playerTwo, setPlayerTwo] = useState([]);
    var [indexOne, setIndexOne] = useState(1);
    var [indexTwo, setIndexTwo] = useState(1);
    

    useEffect(() => {
        fetch(`ship/`)
            .then((results) => {
                return results.json();
            })
            .then(data => {
                setShot(data);
            })
    }, [])

    var tab = shot
    var tab2 = shot
    var tab3 = [];
    var tab4 = [];
    var xz = [];


    var x = -1;
    var lengthPlayerOne = 0;
    var lengthPlayerTwo = 0;
    

    const handleClick = () => {
        setPlayerOne(playerOne = []);
        setPlayerTwo(playerTwo = []);
        setIndexOne(indexOne = 1);
        setIndexTwo(indexTwo = 1);
        x = -1;
        lengthPlayerOne = 0;
        lengthPlayerTwo = 0;

        const interval = setInterval(() => {

            if (x === -1) {
                x = tab[0];
                lengthPlayerOne = x[0];
                lengthPlayerTwo = x[1];
            }

            console.log(indexOne);
            console.log(tab[indexOne]); 

            xz = tab[indexOne];
            tab3.push(xz[0]);
            tab3.push(xz[1]);

            setPlayerOne(playerOne = tab3);
            setIndexOne(indexOne = indexOne + 1); 
            
            if (indexTwo > (lengthPlayerTwo + lengthPlayerOne)) {
                alert("End Game, Player One Win!!!");
                clearInterval(interval);
            }
            setTimeout(() => {
                if (indexTwo === 1) indexTwo = lengthPlayerOne+1;

                console.log(indexTwo);
                console.log(tab[indexTwo]);

                xz = tab[indexTwo];
                tab4.push(xz[0]);
                tab4.push(xz[1]);

                setPlayerTwo(playerTwo = tab4);
                setIndexTwo(indexTwo = indexTwo + 1);

                if (indexOne > lengthPlayerOne) {
                    alert("End Game, Player Two Win!!!");
                    clearInterval(interval);
                }            
            }, 300)
        }, 800)     
    }
    
    return (
        <div>
            <div className='btn ' onClick={handleClick} >Start Game</div>
            <GamePage tabPlayer1={playerOne} tabPlayer2={playerTwo} />
        </div>
    )
}
