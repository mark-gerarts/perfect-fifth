namespace P5

module Events =

    open Fable.Core
    open P5.Core

    type DeviceOrientation =
        | Landscape
        | Portrait
        | Unknown

    [<Emit("$0.deviceOrientation")>]
    let private deviceOrientation_ (p5: P5) : string = jsNative

    let deviceOrientation (p5: P5) : DeviceOrientation =
        match deviceOrientation_ p5 with
        | "landscape" -> Landscape
        | "portrait" -> Portrait
        | _ -> Unknown

    [<Emit("$0.accelerationX")>]
    let accelerationX (p5: P5) : float = jsNative

    [<Emit("$0.accelerationY")>]
    let accelerationY (p5: P5) : float = jsNative

    [<Emit("$0.accelerationZ")>]
    let accelerationZ (p5: P5) : float = jsNative

    [<Emit("$0.pAccelerationX")>]
    let pAccelerationX (p5: P5) : float = jsNative

    [<Emit("$0.pAccelerationY")>]
    let pAccelerationY (p5: P5) : float = jsNative

    [<Emit("$0.pAccelerationZ")>]
    let pAccelerationZ (p5: P5) : float = jsNative

    [<Emit("$0.rotationX")>]
    let rotationX (p5: P5) : float = jsNative

    [<Emit("$0.rotationY")>]
    let rotationY (p5: P5) : float = jsNative

    [<Emit("$0.rotationZ")>]
    let rotationZ (p5: P5) : float = jsNative

    [<Emit("$0.pRotationX")>]
    let pRotationX (p5: P5) : float = jsNative

    [<Emit("$0.pRotationY")>]
    let pRotationY (p5: P5) : float = jsNative

    [<Emit("$0.pRotationZ")>]
    let pRotationZ (p5: P5) : float = jsNative

    type TurnAxis =
        | X
        | Y
        | Z

    [<Emit("$0.turnAxis")>]
    let private turnAxis_ (p5: P5) : string = jsNative

    let turnAxis (p5: P5) : TurnAxis =
        match turnAxis_ p5 with
        | "X" -> X
        | "Y" -> Y
        | "Z" -> Z
        | _ -> failwith "Unexpected response from p5"

    [<Emit("$0.setMoveThreshold($1)")>]
    let setMoveThreshold (p5: P5) (value: float) : Unit = jsNative

    [<Emit("$0.setShakeThreshold($1)")>]
    let setShakeThreshold (p5: P5) (value: float) : Unit = jsNative

    [<Emit("$0.keyIsPressed")>]
    let keyIsPressed (p5: P5) : bool = jsNative

    [<Emit("$0.key")>]
    let key (p5: P5) : string = jsNative

    type KeyCode =
        | Backspace
        | Tab
        | Enter
        | Shift
        | Control
        | Alt
        | Option
        | Escape
        | LeftArrow
        | UpArrow
        | RightArrow
        | DownArrow
        | Delete
        | Other of int

        member self.getKeyCode() : int =
            match self with
            | Backspace -> 8
            | Tab -> 9
            | Enter -> 13
            | Shift -> 16
            | Control -> 17
            | Alt -> 18
            | Option -> 19
            | Escape -> 27
            | LeftArrow -> 37
            | UpArrow -> 38
            | RightArrow -> 39
            | DownArrow -> 40
            | Delete -> 46
            | Other c -> c

    let private parseKeyCode code =
        match code with
        | 8 -> Backspace
        | 9 -> Tab
        | 13 -> Enter
        | 16 -> Shift
        | 17 -> Control
        | 18 -> Alt
        | 19 -> Option
        | 27 -> Escape
        | 37 -> LeftArrow
        | 38 -> UpArrow
        | 39 -> RightArrow
        | 40 -> DownArrow
        | 46 -> Delete
        | c -> Other c

    [<Emit("$0.keyCode")>]
    let private keyCode_ (p5: P5) : int = jsNative

    let keyCode (p5: P5) : KeyCode = keyCode_ p5 |> parseKeyCode

    [<Emit("$0.keyIsDown($1)")>]
    let keyIsDown (p5: P5) (key: int) : bool = jsNative

    let keyCodeIsDown (p5: P5) (key: KeyCode) : bool = keyIsDown p5 (key.getKeyCode ())

    [<Emit("$0.mouseX")>]
    let mouseX (p5: P5) : int = jsNative

    [<Emit("$0.mouseY")>]
    let mouseY (p5: P5) : int = jsNative
