module P5Reference.Structure.IsLooping

open P5.Core
open P5.Color
open P5.Shape
open P5.DOM
open P5.Structure
open P5.Environment

type State() =
    member val backgroundColor = (Grayscale 255) with get, set
    member val fillColor = (Grayscale 255) with get, set

    member this.randomize() =
        let r = System.Random()
        this.backgroundColor <- (RGB(r.Next(255), r.Next(255), r.Next(255)))
        this.fillColor <- (RGB(r.Next(255), r.Next(255), r.Next(255)))

let changeBG p5 (state: State) =
    if isLooping p5 then
        do state.randomize ()

let checkLoop p5 (el: P5Element<bool>) =
    if el.isChecked () then do loop p5 else noLoop p5

let setup p5 =
    let state = new State()

    let button = createButton p5 "Colorize if loop()"
    button.setPosition 0 120
    button.mousePressed (fun ev -> changeBG p5 state)

    let checkbox = createCheckboxWithLabelAndValue p5 "loop()" true
    checkbox.changed (fun ev -> checkLoop p5 checkbox)

    state

let draw p5 (state: State) =
    let frameCount = frameCount p5
    let width = width p5
    let height = height p5

    background p5 state.backgroundColor
    fill p5 state.fillColor
    circle p5 (frameCount % width |> float) (height / 2 |> float) 50


let run node = simulate node setup noUpdate draw
