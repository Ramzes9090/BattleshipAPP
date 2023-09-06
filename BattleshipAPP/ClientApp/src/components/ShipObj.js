import React from 'react'

const ShipObj = function (_id, _shipName, _startColumn, _startRow, _lengthShip,_horizontal) {
    var id = _id;
    var shipName = _shipName;
    var strCol = _startColumn;
    var strRow = _startRow;
    var length = _lengthShip;
    var horizontal = _horizontal;
    return { id, shipName, strCol, strRow, length, horizontal };
};
export default ShipObj;