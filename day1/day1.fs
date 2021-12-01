module Day1

let readLines filePath = System.IO.File.ReadLines filePath

let input() =
    readLines "input.txt"
    |> Seq.map int

let test = [ 199;
             200;
             208;
             210;
             200;
             207;
             240;
             269;
             260;
             263]

let part1 measurements =
    Seq.pairwise measurements
    |> Seq.map (fun (prev, cur) -> if cur > prev then 1 else 0)
    |> Seq.sum

let answer1 = input() |> part1

let part2 (measurements : int seq) =
    Seq.windowed 3 measurements
    |> Seq.map Array.sum
    |> part1

let answer2 = input() |> part2
