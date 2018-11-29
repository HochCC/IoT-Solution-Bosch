 
        var myChart = echarts.init(document.getElementById('main')); 
     
        option = {
            grid: {
                left: '33',
                right: '33',
                bottom: '30'
            },
            tooltip: {
                trigger: 'axis',
                axisPointer: {
                    type: 'cross',
                    label: {
                        backgroundColor: '#283b56'
                    }
                }
            },
            legend: {
                data: ['in Use Pallet', 'in Use Tb', 'Broken Tb']
            },
            toolbox: {
                show: true,
                feature: {
                    dataView: { readOnly: false }, 
                }
            },
            dataZoom: {
                show: false,
                start: 0,
                end: 100
            },
            xAxis: [
                {
                    show: true,
                    gridIndex: 0,
                    type: 'category',
                    boundaryGap: true,
                    axisLine: { onZero: false },
                    boundaryGap: false,
                    data: (function () {
                        var now = new Date();
                        var res = [];
                        var len = 15;
                        while (len--) {
                            res.unshift(now.toLocaleTimeString().replace(/^\D*/, ''));
                            now = new Date(now - 2000);
                        }
                        return res;
                    })()
                },
                {
                    show: false,
                    gridIndex: 0,
                    type: 'category',
                    boundaryGap: false,
                    data: (function () {
                        var res = [];
                        var len = 15;
                        while (len--) {
                            res.push(15 - len - 1);
                        }
                        return res;
                    })()
                }
            ],
            yAxis: [
                {
                    type: 'value',
                    gridIndex: 0,
                    scale: true,
                    splitLine: {
                        show: false
                    },
                    name: 'In use %',
                    max: 100,
                    min: 0,
                },
                {
                    type: 'value',
                    gridIndex: 0,
                    scale: true,
                    splitLine: {
                        show: false
                    },
                    name: 'Number',
                    max: 500,
                    min: 0,
                }
            ],
            series: [
                {
                    name: 'in Use Pallet',
                    type: 'line',
                    xAxisIndex: 1,
                    yAxisIndex: 1,
                    data: (function () {
                        var res = [];
                        var len = 15;
                        while (len--) {
                            res.push(Math.round(Math.random() * 100 + 320).toFixed(0));
                        }
                        return res;
                    })()
                },
                {
                    name: 'in Use Tb',
                    type: 'line',
                    stack: 1,
                    color: '',
                    areaStyle: { normal: {} },
                    data: (function () {
                        var res = [];
                        var len = 0;
                        while (len < 15) {
                            res.push((Math.random() * 10 + 50).toFixed(1));
                            len++;
                        }
                        return res;
                    })()
                }, 
                {
                    name: 'Broken Tb',
                    type: 'line',
                    stack: 1,
                    areaStyle: { normal : {   
                                        color:'#FA5858'   
                                } },
					itemStyle : {  
                                normal : {  
                                    lineStyle:{  
                                        color:'#FA5858'  
                                    }  
                                }  
                            },  
                    data: (function () {
                        var res = [];
                        var len = 0;
                        while (len < 15) {
                            res.push((Math.random() * 1 + 5).toFixed(1));
                            len++;
                        }
                        return res;
                    })()
                }

            ]
        };

        myChart.count = 15;
        setInterval(function () {
            axisData = (new Date()).toLocaleTimeString().replace(/^\D*/, '');

            var data0 = option.series[0].data;
            var data1 = option.series[1].data;
            var data2 = option.series[2].data; 
            data0.shift();
            data0.push(Math.round(Math.random() * 100 + 320).toFixed(0));
            data1.shift();
            data1.push((Math.random() * 10 + 54).toFixed(1));
            data2.shift();
            data2.push((Math.random() * 1 + 5).toFixed(1)); 

            option.xAxis[0].data.shift();
            option.xAxis[0].data.push(axisData);
            option.xAxis[1].data.shift();
            option.xAxis[1].data.push(myChart.count++);
            myChart.setOption(option);
        }, 1500);
        window.onresize = myChart.resize; 