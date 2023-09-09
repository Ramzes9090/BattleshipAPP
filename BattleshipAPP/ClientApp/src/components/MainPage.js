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

    var x = null
    var lengthPlayerOne = 0;
    var lengthPlayerTwo = 0;

    const handleClick = () => {
        const interval = setInterval(() => {

        if (x === null) {
            x = tab[0];
            lengthPlayerOne = x[0];
            lengthPlayerTwo = x[1];
        }

        console.log(tab[indexOne]);  
        setPlayerOne(playerOne = tab[indexOne])
        console.log(indexOne);
        setIndexOne(indexOne=indexOne+1);      
            if (indexOne >= lengthPlayerOne) {
                alert("End Game, Player Two Win!!!")
                clearInterval(interval);
            }

        setTimeout(() => {
            if (indexTwo === 1) indexTwo = indexTwo + lengthPlayerOne;
            console.log(tab[indexTwo]);
            setPlayerTwo(playerTwo = tab[indexTwo])
            console.log(indexTwo);
            setIndexTwo(indexTwo = indexTwo + 1);

            if (indexTwo >= (lengthPlayerTwo + lengthPlayerOne)) {
                alert("End Game, Player One Win!!!")
                clearInterval(interval);
            }
        },1000)
          
        },2000)
    }


    return (
        <div>
            <div className='btn ' onClick={handleClick} >Click Me</div>
            <GamePage tabPlayer1={playerOne} tabPlayer2={playerTwo} />
        </div>
    )
}
