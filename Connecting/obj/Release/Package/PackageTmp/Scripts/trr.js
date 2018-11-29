// 基于准备好的dom，初始化echarts实例
var myChart = echarts.init(document.getElementById('main4'));

// 指定图表的配置项和数据
var XZ = new Array();
var YZ = new Array();
var array = @Html.Raw(Json.Encode((Model).Select(m => new
    {
        id = m.Status,
        name = m.Status.Count()
    })
));

for (i in array) {
    XZ[i] = array[i].id
}
for (i in array) {
    YZ[i] = array[i].name
}
var option = {
    title: {
        text: 'ECharts 入门示例'
    },
    tooltip: {},
    legend: {
        data: ['销量']
    },
    xAxis: {
        data: XZ
    },
    yAxis: {},
    series: [{
        name: '销量',
        type: 'bar',
        data: YZ
    }]
};

// 使用刚指定的配置项和数据显示图表。
myChart.setOption(option);