// Learn more about F# at http://fsharp.org

open System
open System.IO

let inputs = File.ReadAllLines("Day1Input.txt") 
            |> Seq.toList 
            |> Seq.map Int32.Parse

for x in inputs do
    for y in inputs do
        if x + y = 2020 then 
            let answer = x * y |> string
            printfn "%A" answer