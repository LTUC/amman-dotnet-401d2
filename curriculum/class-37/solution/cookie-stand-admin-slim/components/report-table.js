
export default function ReportTable(props) {

    return (
        <div className="text-center text-gray-700">
            <p className="my-8 ">Report Table Coming Soon...</p>
            <pre>
                {JSON.stringify(props.report)}
            </pre>
        </div>

    );
}
