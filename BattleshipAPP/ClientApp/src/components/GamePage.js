import React, { useState, useEffect } from 'react';
import Board from './Board';
import ShipObj from './ShipObj';

const GamePage = () => {

    const [items, setItems] = useState([]);
    const classShip = 1;

    useEffect(() => {
        fetch(`ship/${classShip}`)
            .then((results) => {               
                return results.json();
            })
            .then(data => {
                setItems(data);               
            })
    }, [])

    var shipObjOne = '';
    var shipObjTwo = '';
    var shipObjThree = '';
    var shipObjFour = '';
    var shipObjFive = '';
    var shipObjSix = '';
    var shipObjSeven = '';
    var shipObjEight = '';
    
        items.map((item) => {
            if (item.id == 1) {
                shipObjOne = ShipObj(item.id, item.shipName, item.startColumn, item.startRow, item.lengthShip, item.horizontal);
            }
            if (item.id == 2) {
                shipObjTwo = ShipObj(item.id, item.shipName, item.startColumn, item.startRow, item.lengthShip, item.horizontal);
            }
            if (item.id == 3) {
                shipObjThree = ShipObj(item.id, item.shipName, item.startColumn, item.startRow, item.lengthShip, item.horizontal);
            }
            if (item.id == 4) {
                shipObjFour = ShipObj(item.id, item.shipName, item.startColumn, item.startRow, item.lengthShip, item.horizontal);
            }
            if (item.id == 5) {
                shipObjFive = ShipObj(item.id, item.shipName, item.startColumn, item.startRow, item.lengthShip, item.horizontal);
            }
            if (item.id == 6) {
                shipObjSix = ShipObj(item.id, item.shipName, item.startColumn, item.startRow, item.lengthShip, item.horizontal);
            }
            if (item.id == 7) {
                shipObjSeven = ShipObj(item.id, item.shipName, item.startColumn, item.startRow, item.lengthShip, item.horizontal);
            }
            if (item.id == 8) {
                shipObjEight = ShipObj(item.id, item.shipName, item.startColumn, item.startRow, item.lengthShip, item.horizontal);
            }
        })
    
    console.log(shipObjOne);
    
    
    return (
        <div>
            <div>
                < Board shipOne={shipObjOne} shipTwo={shipObjTwo} shipThree={shipObjThree} shipFour={shipObjFour} />
            </div>
            <br /><br />
            <div>
                < Board shipOne={shipObjFive} shipTwo={shipObjSix} shipThree={shipObjSeven} shipFour={shipObjEight} />
            </div>
            <br /><br />
        </div>
        
    )
}
export default GamePage;