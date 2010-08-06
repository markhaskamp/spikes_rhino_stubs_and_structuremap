require 'rubygems'
require 'albacore'

rakefile = __FILE__
home_dir = "#{rakefile}/../.."

task :default => :build

desc "show local variables"
task :show do
  puts "home_dir: \t#{home_dir}"
end

desc "clean and build"
msbuild :build => [:clean] do |msb|
  msb.properties :configuration => :Debug
  msb.targets :Build
  msb.solution = "#{home_dir}/app/RhinoSpike/RhinoSpike.sln"
end

msbuild :clean do |msb|
  msb.properties :configuration => :Debug
  msb.targets :Clean
  msb.solution = "#{home_dir}/app/RhinoSpike/RhinoSpike.sln"
end

desc "run mspec tests"
task :test => [:build] do |t|
  sh "#{home_dir}/tools_bundle/mspec/mspec --html #{home_dir}/rpt/specs.html #{home_dir}/test/RhinoSpike.Test/bin/Debug/RhinoSpike.Test.dll"
end
