function solution(radius, height) {
    let volume = (1 / 3) * Math.PI * Math.pow(radius, 2) * height
    let slantHeight = Math.sqrt(Math.pow(radius, 2) + Math.pow(height, 2))
    let lateralSurfaceArea  = Math.PI * radius * slantHeight
    let baseSurfaceArea = Math.PI * Math.pow(radius, 2)
    let area = lateralSurfaceArea + baseSurfaceArea
    console.log('volume = ' + volume.toFixed(4))
    console.log('area = ' + area.toFixed(4))
}
