import React, { useState, useEffect } from 'react'
import GamePage from './GamePage'

// Represents a 10 x 10 grid of grid squares

export default function MainPage() {
    const [shot, setShot] = useState([]);


    useEffect(() => {
        fetch(`ship/`)
            .then((results) => {
                return results.json();
            })
            .then(data => {
                setShot(data);
            })
    }, [])
    console.log(shot)
    return (
        <div>
        <GamePage/>
        </div>
    )
}
