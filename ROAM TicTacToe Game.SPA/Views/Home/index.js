import React from "react";
import { render } from "react-dom";

const boxStyle = {
    width: "30%",
    height: "100px",
    background: "gray",
    float: "left",
    margin: "5px",
    color: "white",
    verticalAlign: "middle",
    display: "flex",
    alignItems: "center",
    justifyContent: "center"
};

class App extends React.Component {
    render() {
        return <GridComponent />;
    }
}

class BoxComponent extends React.Component {
    render() {
        return (
            <div style={boxStyle} onClick={this.props.onClick}>
                {this.props.name}
            </div>
        );
    }
}

class GridComponent extends React.Component {
    constructor() {
        super();

        this.players = ["X", "O"];
        this.boxes = 9;

        this.state = {
            turn: this.players[0],
            grid: new Array(this.boxes).fill("")
        };
    }

    setMark = index => {
        this.setState(prevState => {
            const newGrid = [...prevState.grid];
            newGrid[index] = prevState.turn;
            return {
                turn:
                prevState.turn === this.players[0]
                    ? this.players[1]
                    : this.players[0],
                grid: newGrid
            };
        });
    };

    render() {
        return (
            <div className="grid">
                {this.state.grid.map((box, index) => {
                    return (
                        <BoxComponent
                            key={index}
                            onClick={e => {
                                this.setMark(index);
                            }}
                            name={box}
                        >
                            {box}
                        </BoxComponent>
                    );
                })}
            </div>
        );
    }
}

export default App;

render(<App />, document.getElementById("root"));
