function showRink() {
    var fullHorzSvg = d3.select("#full-rink-horz")
         .append("svg")
         .attr("width", 1000)
         .attr("height", 500);

    var fullHorzPlot = new RINK_MAP({parent: fullHorzSvg, fullRink: true, desiredWidth: 400, horizontal: true});

    fullHorzPlot();
}

