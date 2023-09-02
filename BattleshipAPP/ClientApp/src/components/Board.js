import React from 'react';
import Rect from './Rect';


const Board = () => {
    return (
        <div style={{
            background: "linear-gradient(45deg, #53A658, yellow 50%, #ED564D)",
            height: "400px",
            width: "400px",
            display: "flex",
            flexWrap: "wrap"
        }}>
            {new Array(100).fill(1).map(n => <Rect/>)}
        </div>
    )
}
export default Board;