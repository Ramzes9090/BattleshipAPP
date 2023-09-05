import React, { useState, useEffect } from 'react';

const GamePage = () => {

    var responseClone;

    const [items, setItems] = useState([]);
    const ids = 1;

    useEffect(() => {
        fetch(`ship/${ids}`)
            .then((results) => {               
                return results.json();
            })
            .then(data => {
                setItems(data);               
            })
    }, [])
    

    //var strCol;
    //var strRow;
    //var length;
    //let horizonral;

    //if (items != null) {
    //    items.map((item) => {
    //        strCol = item.startColumn,
    //            strRow = item.startRow,
    //            length = item.lengthShip,
    //            horizonral = item.horizontal
    //    })
    //    PlaceShip(strCol, strRow, length, horizonral)
    //}

    return (
        <div>
            {
                (items != null) ? items.map((item) => <h3>{item.shipName}</h3>) : <div>Loading ... </div>
            }
        </div>
    )
}
export default GamePage;