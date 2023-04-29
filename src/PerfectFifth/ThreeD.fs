namespace P5

module ThreeD =

    open Fable.Core
    open Fable.Core.JsInterop
    open P5.Core
    open Color
    open Math

    type P5Camera =
        [<Emit("$0.pan($1)")>]
        member _.pan(angle: float) : Unit = jsNative

        [<Emit("$0.tilt($1)")>]
        member _.tilt(angle: float) : Unit = jsNative

    [<Emit("$0.createCamera()")>]
    let createCamera (p5: P5) : P5Camera = jsNative

    [<Emit("$0.orbitControl()")>]
    let orbitControl (p5: P5) : Unit = jsNative

    [<Emit("$0.orbitControl($1, $2, $3)")>]
    let orbitControlWithSensitivity (p5: P5) (x: float) (y: float) (z: float) : Unit = jsNative

    [<Emit("$0.normalMaterial()")>]
    let normalMaterial (p5: P5) : Unit = jsNative

    let ambientLight (p5: P5) = emitColorFunction p5 "ambientLight"

    let specularColor (p5: P5) = emitColorFunction p5 "specularColor"

    [<Emit("$0.lights($1)")>]
    let lights (p5: P5) : Unit = jsNative

    [<Emit("$0.lightFalloff($1, $2, $3)")>]
    let lightFalloff (p5: P5) (constant: float) (linear: float) (quadratic: float) : Unit = jsNative

    [<Emit("$0.shininess($1)")>]
    let shininess (p5: P5) (shininess: float) : Unit = jsNative

    let directionalLight (p5: P5) (c: Color) (x: float) (y: float) (z: float) : Unit =
        emitJsExpr (p5, ensureP5Color p5 c, x, y, z) "$0.directionalLight($1, $2, $3, $4)"

    let directionalLightFromVector (p5: P5) (c: Color) (v: P5Vector) : Unit =
        emitJsExpr (p5, ensureP5Color p5 c, v) "$0.directionalLight($1, $2)"

    let pointLight (p5: P5) (c: Color) (x: float) (y: float) (z: float) : Unit =
        emitJsExpr (p5, ensureP5Color p5 c, x, y, z) "$0.pointLight($1, $2, $3, $4)"

    let pointLightFromVector (p5: P5) (c: Color) (v: P5Vector) : Unit =
        emitJsExpr (p5, ensureP5Color p5 c, v) "$0.pointLight($1, $2)"

    /// It would be a bit ridiculous to implement all different variations, so
    /// only color + vector it is.
    let spotLight (p5: P5) (color: Color) (position: P5Vector) (direction: P5Vector) : Unit =
        emitJsExpr (p5, ensureP5Color p5 color, position, direction) "$0.spotLight($1, $2, $3)"

    let spotLightWithOptions
        (p5: P5)
        (color: Color)
        (position: P5Vector)
        (direction: P5Vector)
        (angle: float)
        (concentration: float)
        : Unit =
        emitJsExpr
            (p5, ensureP5Color p5 color, position, direction, angle, concentration)
            "$0.spotLight($1, $2, $3, $4, $5)"

    [<Emit("$0.noLights()")>]
    let noLights (p5: P5) : Unit = jsNative

    let specularMaterial (p5: P5) (c: Color) =
        emitColorFunction p5 "specularMaterial" c

    let ambientMaterial (p5: P5) = emitColorFunction p5 "ambientMaterial"

    [<Emit("$0.ortho($1, $2, $3, $4, $5, $6)")>]
    let ortho (p5: P5) (left: float) (right: float) (bottom: float) (top: float) (near: float) (far: float) : Unit =
        jsNative

    [<Emit("$0.ortho()")>]
    let orthoWithDefaults (p5: P5) = jsNative

    [<Emit("$0.debugMode()")>]
    let debugMode (p5: P5) : Unit = jsNative

    let debugModeGrid (p5: P5) : Unit =
        let p5' = unbox<obj> p5
        let grid = p5'?("GRID")

        emitJsExpr (p5, grid) "$0.debugMode($1)"

    type GridOptions =
        { gridSize: float
          gridDivisions: float
          xOff: float
          yOff: float
          zOff: float }

    let debugModeGridWithOptions (p5: P5) (options: GridOptions) : Unit =
        let p5' = unbox<obj> p5
        let grid = p5'?("GRID")

        emitJsExpr
            (p5, grid, options.gridSize, options.gridDivisions, options.xOff, options.yOff, options.zOff)
            "$0.debugMode($1, $2, $3, $4, $5, $6)"

    let debugModeAxes (p5: P5) : Unit =
        let p5' = unbox<obj> p5
        let axes = p5'?("AXES")

        emitJsExpr (p5, axes) "$0.debugMode($1)"

    type AxesOptions =
        { axesSize: float
          xOff: float
          yOff: float
          zOff: float }

    let debugModeAxesWithOptions (p5: P5) (options: AxesOptions) : Unit =
        let p5' = unbox<obj> p5
        let axes = p5'?("AXES")

        emitJsExpr
            (p5, axes, options.axesSize, options.xOff, options.yOff, options.zOff)
            "$0.debugMode($1, $2, $3, $4, $5)"

    let debugModeAll (p5: P5) (gridOpts: GridOptions) (axesOpts: AxesOptions) : Unit =
        emitJsExpr
            (p5,
             gridOpts.gridSize,
             gridOpts.gridDivisions,
             gridOpts.xOff,
             gridOpts.yOff,
             gridOpts.zOff,
             axesOpts.axesSize,
             axesOpts.xOff,
             axesOpts.yOff,
             axesOpts.zOff)
            "$0.debugMode($1, $2, $3, $4, $5, $6, $7, $8, $9)"

    [<Emit("$0.noDebugMode($1)")>]
    let noDebugMode (p5: P5) : Unit = jsNative

    [<Emit("$0.camera($1, $2, $3, $4, $5, $6, $7, $8, $9)")>]
    let camera
        (p5: P5)
        (x: float)
        (y: float)
        (z: float)
        (centerX: float)
        (centerY: float)
        (centerZ: float)
        (upX: float)
        (upY: float)
        (upZ: float)
        : Unit =
        jsNative

    type P5Shader =
        member self.setUniform (name: string) (data: obj) : Unit =
            emitJsExpr (self, name, data) "$0.setUniform($1, $2)"

    [<Emit("$0.loadShader($1, $2)")>]
    let loadShader (p5: P5) (verFilename: string) (fragFilename: string) : P5Shader = jsNative

    [<Emit("$0.loadShader($1, $2, $3, $4)")>]
    let loadShaderWithCallbacks
        (p5: P5)
        (verFilename: string)
        (fragFilename: string)
        (onSuccess: P5Shader -> Unit)
        (onError: P5Shader -> Unit)
        : P5Shader =
        jsNative

    [<Emit("$0.createShader($1, $2)")>]
    let createShader (p5: P5) (vertSrc: string) (fragSrc: string) : P5Shader = jsNative

    [<Emit("$0.shader($1)")>]
    let shader (p5: P5) (shader: P5Shader) : Unit = jsNative

    let setShader = shader

    [<Emit("$0.resetShader()")>]
    let resetShader (p5: P5) : Unit = jsNative

    [<Emit("$0.texture($1)")>]
    let texture (p5: P5) (texture: IImage) : Unit = jsNative

    let setTexture = texture

    type TextureMode =
        | Image
        | Normal

    let textureMode (p5: P5) (mode: TextureMode) : Unit =
        let p5' = unbox<obj> p5

        let rawMode =
            match mode with
            | Image -> p5'?("IMAGE")
            | Normal -> p5'?("NORMAL")

        emitJsExpr (p5, rawMode) "$0.textureMode($1)"

    let setTextureMode = textureMode
