require 'rubygems'
require 'albacore'

rakefile = __FILE__
@home_dir = File.dirname(rakefile) + '/..'

desc "'test' is the default task"
task :default => :test

desc "show local variables"
task :show do
  puts "@home_dir: \t#{@home_dir}"
end

desc "clean then build"
msbuild :build => [:clean] do |msb|
  msb.properties :configuration => :Debug
  msb.targets :Build
  msb.solution = "#{@home_dir}/app/RhinoSpike/RhinoSpike.sln"
end

msbuild :clean do |msb|
  msb.properties :configuration => :Debug
  msb.targets :Clean
  msb.solution = "#{@home_dir}/app/RhinoSpike/RhinoSpike.sln"
end

desc 'build then test - also create rpt/specs.html report.'
task :test => :build do |t|
  @output_target = "--html #{@home_dir}/rpt/specs.html"
  run_tests_and_direct_output
end

def run_tests_and_direct_output
  sh "#{@home_dir}/tools_bundle/mspec/mspec #{@output_target} #{@home_dir}/test/RhinoSpike.Test/bin/Debug/RhinoSpike.Test.dll"
end
