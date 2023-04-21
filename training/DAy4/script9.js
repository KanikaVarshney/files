console.log("Using FEtch Api")

// fetch(url).then(res).then()

fetch('text.txt')
.then(res=> res.text())
.then(data => console.log(data))


fetch('db.json')
.then(res=> res.json())
.then(data => console.log(data))