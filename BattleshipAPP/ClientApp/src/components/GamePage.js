import React, { useState, useEffect } from 'react';
import Board from './Board';
import ShipObj from './ShipObj';

const GamePage = () => {

    const [items, setItems] = useState([]);
    const [shot, setShot] = useState([]);

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
    
    //console.log(shipObjOne);

    function addFiled(a, b) {
        tab.push(a)
        tab.push(b)
    }
    var tab2 = [1, 4, 3, 2, 3, 8, 9, 9]
    var tab = [];

    var [count, setCount] = useState([]);

    const handleClick = () => {
        // Increment the count when the button is clicked
        
        let i = 0;
        const interval = setInterval(() => {
            addFiled(tab2[i],tab2[i=i+1])
            i = i + 2;
            setCount(count = tab)
            console.log(count);
            console.log(i);
            
            if (i > tab2.length) clearInterval(interval);
        
        }, 3000)
    };
 
    
    return (
        <div>
            <div className='btn ' onClick={handleClick} >Click Me</div>
            <div>
                < Board shipOne={shipObjOne} shipTwo={shipObjTwo} shipThree={shipObjThree} shipFour={shipObjFour} tab={ count} />
            </div>
            <br /><br />
            <div>
                < Board shipOne={shipObjFive} shipTwo={shipObjSix} shipThree={shipObjSeven} shipFour={shipObjEight} tab={ tab} />
            </div>
            <br /><br />
        </div>
        
            )
}       
export default GamePage;