namespace P5

module DOM =

    open Fable.Core
    open P5.Core
    open Browser.Types

    type PositionType =
        | Static
        | Fixed
        | Relative
        | Sticky
        | Initial
        | Inherit

    type Position = { x: float; y: float }

    let private rawPositionType positionType =
        match positionType with
        | Static -> "static"
        | Fixed -> "fixed"
        | Relative -> "relative"
        | Sticky -> "sticky"
        | Initial -> "initial"
        | Inherit -> "inherit"

    type P5Element<'T> =
        [<Emit("$0.center()")>]
        member _.center() : Unit = jsNative

        [<Emit("$0.center($1)")>]
        member _.centerWithAlign(align: string) : Unit = jsNative

        [<Emit("$0.style($1, $2)")>]
        member _.style (property: string) (value: string) : Unit = jsNative

        [<Emit("$0.position()")>]
        member _.getPosition: Position = jsNative

        [<Emit("$0.position($1, $2, $3)")>]
        member private _.setPosition_ (x: float) (y: float) (positionType: string) : Unit = jsNative

        [<Emit("$0.position($1, $2)")>]
        member _.setPosition (x: float) (y: float) : Unit = jsNative

        member this.setPositionWithType (x: float) (y: float) (positionType: PositionType) : Unit =
            this.setPosition_ x y (rawPositionType positionType)

        [<Emit("$0.value()")>]
        member _.getValue() : 'T = jsNative

        [<Emit("$0.value($1)")>]
        member _.setValue(value: 'T) : Unit = jsNative

        [<Emit("$0.mousePressed($1)")>]
        member _.mousePressed(f: MouseEvent -> Unit) : Unit = jsNative

        [<Emit("$0.mousePressed(false)")>]
        member _.clearMousePressed() : Unit = jsNative

        /// TODO: what event is fired here?
        [<Emit("$0.changed($1)")>]
        member _.changed(f: obj -> Unit) : Unit = jsNative

        [<Emit("$0.changed(false)")>]
        member _.clearChanged() : Unit = jsNative

        [<Emit("$0.checked()")>]
        member _.isChecked() : bool = jsNative

    [<Emit("$0.createP($1)")>]
    let createP (p5: P5) (innerHTML: string) : P5Element<Unit> = jsNative

    [<Emit("$0.createSlider($1, $2)")>]
    let createSlider (p5: P5) (min: float) (max: float) : P5Element<float> = jsNative

    [<Emit("$0.createSlider($1, $2, $3, $4)")>]
    let createSliderWithOptions (p5: P5) (min: float) (max: float) (value: float) (step: float) : P5Element<float> =
        jsNative

    /// TODO: value
    [<Emit("$0.createButton($1)")>]
    let createButton (p5: P5) (label: string) : P5Element<string> = jsNative

    [<Emit("$0.createCheckbox($1)")>]
    let createCheckboxWithLabel (p5: P5) (label: string) : P5Element<bool> = jsNative

    [<Emit("$0.createCheckbox($1, $2)")>]
    let createCheckboxWithLabelAndValue (p5: P5) (label: string) (value: bool) : P5Element<bool> = jsNative
