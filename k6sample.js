import http from 'k6/http';

export const options = {
  stages: [
    { duration: '30s', target: 5 },
    { duration: '15s', target: 10 },
    { duration: '45s', target: 15 },
  ],
  thresholds: { http_req_duration: ['avg<100', 'p(95)<200'] },
  noConnectionReuse: true,
  userAgent: 'MyK6UserAgentString/1.0',
};

const stocks = ["MSFT", "GOOG", "AAPL", "GME", "AMZN"];

export default function () {
    http.get(`http://localhost:5232/stock/` + stocks[Math.floor(Math.random() * stocks.length)]);
}